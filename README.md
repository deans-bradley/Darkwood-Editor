# Welcome to Darkwood Editor

Darkwood Editor is a save file editor designed for the video game [Darkwood](https://www.darkwoodgame.com/), developed by [Acid Wizard Studio](https://www.acidwizardstudio.com/). With Darkwood Editor, you can modify your `dat.sav` files, giving you the power to customize your Darkwood experience.

![Player Stats Page](https://i.imgur.com/5Sapj6m.png)

## Features

### Edit Player States

Modify your character's states to suit your playstyle. Whether you want to boost your health, stamina, or manage your inventory, Darkwood Editor puts you in control.

### Alter Story Progression

Adjust your progress through the game's story elements. Unlock areas, events, and items to tailor your journey through Darkwood.

### Customize Environment

Tweak environmental elements such as the state of locations, the presence of NPCs, and more, to create the perfect setting for your gameplay.

### Control Time & Weather

Manipulate time and weather conditions within the game world. Whether you prefer clear skies or a stormy atmosphere, Darkwood Editor allows you to set the scene just how you like it.

## Getting Started

Make sure you have Visual Studio installed on your system. You can download it from the [official Visual Studio website](https://visualstudio.microsoft.com/).

### Cloning the Repository

1.  Open Visual Studio.
2.  Go to `View` > `Team Explorer` to open the Team Explorer panel.
3.  Click on the `Clone` button and enter the URL of your Darkwood Editor repository.
4.  Choose a local path where you want to clone the repository and click `Clone`.

**OR**

1. Open Command Prompt.
2. Navigate to `Users` > `Your_Username` > `source`.
3. Execute the below command:

```git
git clone https://github.com/deans-bradley/Darkwood-Editor.git
```

### Opening the Project

1.  After cloning the repository, go to `File` > `Open` > `Project/Solution`.
2.  Navigate to the directory where you cloned the repository and select the solution file (`DarkwoodEditor.sln`).
3.  Click `Open` to load the project into Visual Studio.

### Restoring NuGet Packages

1.  Once the project is loaded, right-click on the solution in the Solution Explorer and select `Restore NuGet Packages`. This will ensure that all necessary dependencies are restored.

### Building the Project

1.  To build the project, simply go to `Build` > `Build Solution` or press `Ctrl + Shift + B`.
2.  Visual Studio will compile the project and ensure that all necessary files are generated.

### Running the Application

1.  To run the Darkwood Editor application from Visual Studio, ensure that the Darkwood Editor project is set as the startup project. You can do this by right-clicking on the Darkwood Editor project in the Solution Explorer and selecting `Set as StartUp Project`.
2.  Press `F5` or go to `Debug` > `Start Debugging` to run the application.

That's it! You're now set up to work on the Darkwood Editor project in Visual Studio. If you encounter any issues or have any questions, feel free to ask for assistance.

## Download the App (unavailable)

If you don't plan on editing the project and would just like to use the app, you can follow the instructions here to get started.

1.  **Download the Application**: Obtain the latest release of Darkwood Editor from the releases section of this repository.
    
2.  **Open `dat.sav` File**: Launch Darkwood Editor and load your `dat.sav` file into the application.
    
3.  **Edit Save File**: Navigate through the different sections (Player Stats, Story, Environment, Time & Weather) and make your desired changes.
    
4.  **Save Changes**: Once you're satisfied with your modifications, save your changes to the `dat.sav` file. A backup `dat.sav` will be made for the original save file.

5. **Enjoy:** Launch Darkwood, load the profile where you made your changes, and have fun!
    

## Requirements

**Target Framework**: .NET 8.0 Windows

**Dependencies**: 
- Newtonsoft.Json (version 13.0.3)
- XamlFlair.WPF (version 1.2.13)

## Contributing

Contributions to Darkwood Editor are welcome! Whether you want to fix a bug, add a feature, or improve documentation, feel free to submit a pull request.

## License

This project is licensed under the MIT License.

## Acknowledgements

Darkwood Editor relies on the following open-source library:

-   **[Newtonsoft](https://www.newtonsoft.com/json)**: A popular JSON framework for .NET.
- **[XamlFlair](https://github.com/XamlFlair/XamlFlair)**: An animation library for XAML.