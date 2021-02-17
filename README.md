# QPV Plugins
Set of preinstalled plugins for the <a href="https://github.com/ModuleArt/quick-picture-viewer">Quick Picture Viewer</a>

### Blur region

### Screenshot

### Crop / Canvas size

Soon...

### Resize

Soon...

### Color picker

Soon...

# How to create a plugin? (API v3)

### Structure:

```txt
my-plugin.zip
│
├─ my-plugin                       // Resources folder (images, libraries...)
│       │
│       ├─ myFunc.light.png        // Function icon
│       ├─ myFunc.dark.png         // Function icon (for dark mode)       
│       └─ my-plugin.dll           // Main library
│
└─ my-plugin.json                  // Props file (name, version, functions...)
```

### Props:

```jsonc
{
  "name": "my-plugin",   // Unique plugin codename                             
  "version": "1.0.0",                                       
  "title": "My plugin",                                                
  "description": {   // Short description in several languages. Supported languages: "en", "ru", "es", "cn", "hu"     
    "en": "This is my plugin"
  },
  "link": "https://github.com/ModuleArt/quick-plugin-template",   // Link to the plugin website/repository
  "authors": [
    {
      "name": "Beelink",   // Nickname or real name of the creator
      "link": "https://github.com/Beelink"   // Link to the creator website/GitHub profile
    }
  ],
  "apiVer": 3,   // Quick Plugins API version. Supported versions: 3
  "inputType": "bitmap",   // The type of data the plugin works with. Supported types: "bitmap"
  "dllType": "csharp",   // Main library type. Supported types: "csharp", "cpp" 
  "functions": [   // List of the all plugin tools and effects
    {
      "name": "myFunc",   // Function name e.g. public Bitmap myFunc(Bitmap bmp, string path)
      "title": {   // Effect or tool title in several languages. Supported languages: "en", "ru", "es", "cn", "hu"   
        "en": "My effect"
      },
      "type": "effect",   // Function type. Supported types: "effect", "tool"
      "inputRequired": true,   // The plugin needs data to work with (see "inputType" prop)
      "dialog": false,   // If function has GUI (dialog window)
      "hideMainForm": false   // If the app's main window should be hidden while the function's dialog opened
    }
  ]
}
```
