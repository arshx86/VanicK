#region

using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

#endregion

namespace vanick
{
    internal class Glow
    {
        internal static async void Run()
        {
            var offsets = Utils.RenewOffsets();
            Process[] proc = Process.GetProcessesByName("csgo");
            Memory.ProcessHandle = Memory.OpenProcess(0x0008 | 0x0010 | 0x0020, false, proc[0].Id);

            //Get the base addy for client.dll & engine.dll inside our csgo.exe
            int clientdll = GetModuleBaseAddress(proc[0], "client.dll");
            int enginedll = GetModuleBaseAddress(proc[0], "engine.dll");

            //Our general settings
            Models.GlowSettingsStruct glowSettingsStruct = new Models.GlowSettingsStruct
            {
                renderOccluded = true,
                renderUnoccluded = false
            };

            //Get our local player
            await Task.Run(() =>
            {
                while (true)
                {
                    //Keep reading our local player coz incase teams change and stuff
                    int LocalPlayer = Memory.ReadMemory<int>(clientdll + offsets.signatures.dwLocalPlayer);
                    int clientstate = Memory.ReadMemory<int>(enginedll + offsets.signatures.dwClientState);
                    int MaxPlayerCount = Memory.ReadMemory<int>(clientstate + offsets.signatures.dwClientState_MaxPlayer);
                    //Basically sleep the hack if ur in menu and such
                    if (MaxPlayerCount < 1)
                    {
                        Thread.Sleep(500);
                        continue;
                    }

                    //Get our glow object
                    int glowObject = Memory.ReadMemory<int>(clientdll + offsets.signatures.dwGlowObjectManager);
                    //Get our team number
                    int myTeam = Memory.ReadMemory<int>(LocalPlayer + offsets.netvars.m_iTeamNum);

                    for (int i = 0; i < MaxPlayerCount; i++)
                    {
                        //The current entity
                        int entity = Memory.ReadMemory<int>(clientdll + offsets.signatures.dwEntityList + i * 0x10);
                        bool bDormant = Memory.ReadMemory<bool>(entity + offsets.signatures.m_bDormant);

                        if (!bDormant)
                        {
                            int glowIndex = Memory.ReadMemory<int>(entity + offsets.netvars.m_iGlowIndex);
                            int entityTeam = Memory.ReadMemory<int>(entity + offsets.netvars.m_iTeamNum);
                            if (myTeam == entityTeam)
                            {
                                Models.GlowColorStruct TeamGlow = Consts.GlowTeam;
                                Memory.WriteMemory<Models.GlowColorStruct>(glowObject + glowIndex * 0x38 + 0x8, TeamGlow);

                                Models.rgba clrRender_t = new Models.rgba
                                {
                                    //*255 idea from: https://stackoverflow.com/a/46575472/12897035
                                    r = (byte)Math.Round(TeamGlow.red * 255.0),
                                    g = (byte)Math.Round(TeamGlow.green * 255.0),
                                    b = (byte)Math.Round(TeamGlow.blue * 255.0),
                                    a = (byte)Math.Round(TeamGlow.alpha * 255.0)
                                };
                                Memory.WriteMemory<Models.GlowColorStruct>(entity + offsets.netvars.m_clrRender, clrRender_t);
                            }
                            else
                            {
                                Models.GlowColorStruct EnemyGlow = Consts.GlowEnemy;

                                // if defusing
                                if (Memory.ReadMemory<bool>(entity + offsets.netvars.m_bIsDefusing))
                                    EnemyGlow = new Models.GlowColorStruct
                                    {
                                        red = 255,
                                        green = 255,
                                        blue = 255,
                                        alpha = 1.7f
                                    };
                                else
                                    Memory.WriteMemory<Models.GlowColorStruct>(glowObject + glowIndex * 0x38 + 0x8, EnemyGlow);

                                Models.rgba clrRender_t = new Models.rgba
                                {
                                    r = (byte)Math.Round(EnemyGlow.red * 255.0),
                                    g = (byte)Math.Round(EnemyGlow.green * 255.0),
                                    b = (byte)Math.Round(EnemyGlow.blue * 255.0),
                                    a = (byte)Math.Round(EnemyGlow.alpha * 255.0)
                                };
                                Memory.WriteMemory<Models.GlowColorStruct>(entity + offsets.netvars.m_clrRender, clrRender_t);

                                //Our teammates are shown on map so we only have to write the radar to our enemies. (Basically this: https://youtu.be/5VOkRJk1GVg)
                                Memory.WriteMemory<bool>(entity + offsets.netvars.m_bSpotted, true);
                            }

                            Memory.WriteMemory<Models.GlowSettingsStruct>(glowObject + glowIndex * 0x38 + 0x28, glowSettingsStruct);
                        }
                    }

                    Thread.Sleep(1); //Change this if ur cpu can't handle it :pepeclown:
                }
            });
        }

        public static int GetModuleBaseAddress(Process process, string moduleName)
        {
            return (int)process.Modules.Cast<ProcessModule>().SingleOrDefault(m => string.Equals(m.ModuleName, moduleName, StringComparison.OrdinalIgnoreCase)).BaseAddress;
        }
    }
}