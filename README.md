# Smart Home IoT

A Windows desktop app that monitors and controls a smart home through **Firebase Realtime Database**:
it shows live temperature and humidity and switches the light and air conditioner on or off.

```
sensors / relays ──► Firebase Realtime Database ◄──► this app (C# WinForms)
                       Sensors/{Temperature,Humidity}     polls readings, shows device status,
                       Device/{Light,Airconditional}      writes ON/OFF commands
```

This repository holds the desktop control app. The microcontroller firmware that writes sensor
readings to Firebase and drives the relays is not included.

## How it works

| Step | Code (`SmartHomeIoTFinalVersion/Form1.cs`) |
|---|---|
| Connect | `GET` the database URL to check it is reachable |
| Read | A timer calls `read_data()`, which fetches `<url>.json` and shows `Sensors/Temperature`, `Sensors/Humidity`, `Device/Aircon_Status` and `Device/Light_Status` |
| Control | The on/off buttons only appear while a device reports `Online`; pressing one sends `PUT <url>/Device/<name>.json` with `"ON"` or `"OFF"` |

Firebase is called through its REST API with `HttpClient` and parsed with Newtonsoft.Json.

## Run

Requirements: Windows, Visual Studio 2015 or later (**.NET desktop development** workload),
.NET Framework 4.5.2 Developer Pack.

1. Open `SmartHomeIoT.sln`.
2. Right-click the solution → **Restore NuGet Packages**.
3. Press **F5**, enter your database URL (ending in `/`), then **Connect** and **Read**.

## Database layout

```json
{
  "Sensors": { "Temperature": 30, "Humidity": 70 },
  "Device":  { "Light": "OFF", "Airconditional": "OFF",
               "Light_Status": "Online", "Aircon_Status": "Online" }
}
```

The app sends no authentication, so the database rules decide who can read and write. Never leave
a database that controls real devices open to public writes.
