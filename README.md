<!--
	Last Testament of Wanderers 
	Copyright (C) 2019 - 2021 WotoTeam
	This file is subject to the terms and conditions defined in
	file 'LICENSE', which is part of the source code.
-->

# Last Testament Of Wanderers
====================================

Welcome to the LTW-client source code! 

Last Testament Of Wanderers, is a open-source MMORPG game.
From this repository you can build LTW game, all of the Contents are included.
Also, some of the game data should be downloaded from the game servers when entring the game.


<!--
[![Join the chat at https://discord.gg/<discordlink>](https://img.shields.io/discord/<discordid>?color=%25237289DA&label=DOT&logo=discord&logoColor=white)](https://discord.gg/<discordlink>)

-->

<!--
https://icons8.com/vue-static/landings/pricing/icons8-license.pdf
-->

 * [Supported Platforms](#supported-platforms)
 * [Support and Contributions](#support-and-contributions)
 * [Source Code](#source-code)
 * [License](#license)


 ## Supported Platforms

 We only support Windows and Linux right now.
 If there is a platform we don't support, please [make a request](https://github.com/intellivoid/LTW-client/issues) or [come help us](CONTRIBUTING.md) add it.

 * Linux
   * Ubuntu 19.04 or later.
   * Arch linux

 * Windows
   * Windows 7 or later.


## Support and Contributions

If you think you have found a bug or have a feature request, feel free to use our [issue tracker](https://github.com/intellivoid/LTW-client/issues). Before opening a new issue, please search to see if your problem has already been reported or not.  Try to be as detailed as possible in your issue reports.

If you need help using LTW or have other questions we suggest you to join our [telegram community](https://t.me/LTW_Game).  Please do not use the GitHub issue tracker for personal support requests.

If you are interested in contributing fixes or features to LTW, please read our [contributors guide](CONTRIBUTING.md) first.

**To get started using GitHub:**

- Create your own LTW **fork** by clicking the __Fork button__ in the top right of this page.
- [Install a Git client](http://help.github.com/articles/set-up-git) on your computer.
- Use the GitHub program to **Sync** the project's files to a folder on your computer.
- Open up **LTW.sln** in your IDE.
- Modify the source codes and test your changes.
- Using the GitHub program, you can easily **submit contributions** back up to your **fork**.
- Do not **commit to master**, for each feature **create new branch**.
- When you're ready to send the changes to the LTW repo for review, simply create a [Pull Request](https://help.github.com/articles/using-pull-requests).

**Advanced topics:**
- You can update your master branch by executing:
  - `git pull https://github.com/intellivoid/LTW-client.git master`
- If your master is tainted and any branch you make contains junk, you can do **hard reset**. All unmerged commits on master branch will be lost.
  - `git checkout master`
  - `git fetch https://github.com/intellivoid/LTW-client.git master`
  - `git reset --hard FETCH_HEAD`
  - `git push --force origin master`


## Source Code

The full source code is available here from GitHub:

 * Clone the source: `git clone https://github.com/intellivoid/LTW-client.git`
 * Open the solution `LTW.sln` or project file `LTW/LTW.csproj`

For the prerequisites for building from source, please look at the [Requirements](REQUIREMENTS.md) file.

## License

The LTW project is under the [GPL v2 License](https://opensource.org/licenses/GPL-2.0).
See the [LICENSE](LICENSE) file for more details.  
Third-party libraries used by LTW are under their own licenses.  Please refer to those libraries for details on the license they use.
