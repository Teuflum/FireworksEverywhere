# FireworksEverywhere
Beat Saber mod that lets you adjust various parameters about the anniversary fireworks that were added with 1.15.

This just exists for me to learn modding the game a little bit...

## Settings
You can adjust several options in the config file `FireworksEverywhere.json` which you can find in your `UserData` folder in your Beat Saber directory.

**If you don't have the file, start the game once and it will get created. You will have to restart the game every time you change something!**

An example config where fireworks spawn really fast and all around you in different colors is included on the release page.

Default values:
```json
{
  "LeaveFireworksEnabled": true,
  "MinSpawnInterval": 0.2,
  "MaxSpawnInterval": 1.0,
  "LightIntensityMultiplier": 1.0,
  "LightFlashDuration": 1.0,
  "MinSpeedMultiplier": 0.8,
  "MaxSpeedMultiplier": 1.16,
  "EnableRandomColors": false,
  "LightsColor": {
    "r": 0.0,
    "g": 0.7529412,
    "b": 1.0,
    "a": 1.0
  },
  "SpawnSize": {
    "x": 30.0,
    "y": 4.0,
    "z": 5.0
  }
}
```

### Leave Fireworks Enabled
- **Setting**: `LeaveFireworksEnabled`
- **Values**: `true` | `false`
- **Default**: `true`

By default, the game stops the fireworks after you leave the main menu by entering a play mode. Setting this to `true` leaves the fireworks on.
*This is the only setting that is different to the default base game values.*

### Minimum Spawn Interval
- **Setting**: `MinSpawnInterval`
- **Unit**: `Seconds`
- **Default**: `0.2`

Sets the minimum spawn interval for each firework.
**Setting this too low can introduce inconsistent audio issues.**

### Maximum Spawn Interval
- **Setting**: `MaxSpawnInterval`
- **Unit**: `Seconds`
- **Default**: `1.0`

Sets the maximum spawn interval for each firework.

### Light Intensity Multiplier
- **Setting**: `LightIntensityMultiplier`
- **Default**: `1.0`

I'm not quite sure how that multiplier actually works and it tends to provide weird results when you go too high, but it's included anyways.

### Light Flash Duration
- **Setting**: `LightFlashDuration`
- **Unit**: `Seconds`
- **Default**: `1.0`

This seems to change how long the lights on each firework flash for, higher numbers can make it weird if you don't lower the speed multipliers at the same time (see below).

### Minimum Speed Multiplier
- **Setting**: `MinSpeedMultiplier`
- **Unit**: `Seconds`
- **Default**: `0.8`

Sets the minimum speed multiplier on how fast each firework can explode.

### Minimum Speed Multiplier
- **Setting**: `MaxSpeedMultiplier`
- **Unit**: `Seconds`
- **Default**: `1.16`

Sets the maximum speed multiplier on how fast each firework can explode.

### Enable Random Colors
- **Setting**: `EnableRandomColors`
- **Values**: `true` | `false`
- **Default**: `false`

Setting this to `true` lets every firework have its own random color.

### Firework Lights Color
- **Setting**: `LightsColor`
- **Default**: `"r": 0.0, "g": 0.7529412, "b": 1.0, "a": 1.0`

**This setting only works if `EnableRandomColors` is disabled.**
Sets the **r**ed, **g**reen, **b**lue and **a**lpha values of your desired static color.
The scale for each value normally goes from 0-1, but you can enter higher numbers for interesting results.

### Spawn Area Size
- **Setting**: `SpawnSize`
- **Default**: `"x": 30.0, "y": 4.0, "z": 5.0`

Sets the size of the area in which fireworks can spawn.
