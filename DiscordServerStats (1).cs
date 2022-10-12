﻿{
  "Stats Messages": [
    {
      "Discord Webhook": "https://discord.com/api/webhooks/1029841912141729802/iFBdqtIZy27SlXrbExAhlz28uQej8zCMA3z2Oj2MBg-kgLyxcje8GVuDVyve4KlMpVMu",
      "Message Update Interval (Minutes)": 2.0,
      "Embed Message": {
        "Content": "",
        "Embeds": [
          {
            "Enabled": true,
            "Title": "{server.name}",
            "Description": "Live Server Stats",
            "Url": "http://www.i4ani.com",
            "Embed Color": "#de8732",
            "Image Url": "",
            "Thumbnail Url": "",
            "Add Timestamp": true,
            "Fields": [
              {
                "Title": "Status",
                "Value": "{discordserverstats.status}",
                "Inline": true,
                "Enabled": true
              },
              {
                "Title": "Online / Max Players",
                "Value": "{server.players} / {server.players.max}",
                "Inline": true,
                "Enabled": true
              },
              {
                "Title": "Sleepers",
                "Value": "{server.players.sleepers}",
                "Inline": true,
                "Enabled": true
              },
              {
                "Title": "Players Loading",
                "Value": "{server.players.loading}",
                "Inline": true,
                "Enabled": true
              },
              {
                "Title": "Players In Queue",
                "Value": "{server.players.queued}",
                "Inline": true,
                "Enabled": true
              },
              {
                "Title": "Map Entities",
                "Value": "{server.entities}",
                "Inline": true,
                "Enabled": true
              },
              {
                "Title": "Seed",
                "Value": "[{world.seed}](https://rustmaps.com/map/{world.size}_{world.seed})",
                "Inline": true,
                "Enabled": true
              },
              {
                "Title": "Size",
                "Value": "{world.size} ({world.size!km^2}km^2)",
                "Inline": true,
                "Enabled": true
              },
              {
                "Title": "Plugin Count",
                "Value": "{plugins.amount}",
                "Inline": true,
                "Enabled": true
              },
              {
                "Title": "Server Framerate",
                "Value": "{server.fps}",
                "Inline": true,
                "Enabled": true
              },
              {
                "Title": "Memory Usage",
                "Value": "{server.memory.used:0.00!GB} GB / {server.memory.total:0!GB} GB",
                "Inline": true,
                "Enabled": true
              },
              {
                "Title": "Network IO",
                "Value": "In: {server.network.in:0.00!KB} KB/s Out: {server.network.out:0.00!KB} KB/s ",
                "Inline": true,
                "Enabled": true
              },
              {
                "Title": "Last Wiped Date Time",
                "Value": "{server.map.wipe.last:MM/dd/yy hh:mm:ss!local}",
                "Inline": true,
                "Enabled": true
              },
              {
                "Title": "Last Joined",
                "Value": "{player.joined.last}",
                "Inline": true,
                "Enabled": true
              },
              {
                "Title": "Last Disconnected",
                "Value": "{player.disconnected.last} ({player.disconnected.last.duration:%h}H {player.disconnected.last.duration:%m}M {player.disconnected.last.duration:%s}S)",
                "Inline": true,
                "Enabled": true
              },
              {
                "Title": "Wipe Schedule",
                "Value": "Map & BP's Monthly ",
                "Inline": true,
                "Enabled": true
              },
              {
                "Title": "Click & Connect",
                "Value": "steam://connect/{server.address}:{server.port}",
                "Inline": false,
                "Enabled": true
              }
            ],
            "Footer": {
              "Icon Url": "",
              "Text": "",
              "Enabled": true
            }
          }
        ]
      }
    }
  ],
  "Debug Level (None, Error, Warning, Info)": "Warning"
}