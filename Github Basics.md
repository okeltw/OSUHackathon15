<b>NOTE:</b> This is meant to cover the basics and some commands.

<h1>About Github</h1>
-
Github is a file and source sharing site that allows multiple developers to collaborate on a single project.

In pursuit of this, Git provides a suite of features that allows us to work separately, afterwards cleanly merge the changes.  This process is known as <i>forking</i>.  Forking a repository creates your own little <i>branch</i> from which to work on.  Each branch has its own copy of the source code, allowing you to work without a collaborator's changes interfering.  Once work completes for a branch, we do what is called a <i>merge</i>.  
Merging takes a source branch and syncs changes with a destination branch.  In some cases, discrepencies which do not allow clean merges must be resolved. At these points, Git will place simple markups in the code that shows the difference.  The user chooses the code to be kept and deletes the rest.  Afterwards, git will merge the changes such that each branch has the same source.

<h2>Github Concepts</h2>
-
- <b>Repositories</b> (repos) are cloud storages of projects - this file is stored in our repository, for instance.  They allow branching, merging, etc. to work on the same code with collaborators.
- <b>Forking</b> creates a copy of a source branch (code) that allows you to work separately from this branch.
- <b>Branches</b> are instances of a fork. Branches are separate copies of other branches, often the "master" branch.
- <b>Master</b> branch is the main source of our code.  All work should be done on separate branches, then merged into master branch once finished and tested. This process allows us to roll back code if a fatal error in the code demands it.
- <b>Merging</b> branches combines the code together.  In cases where code was only added, Git may be able to merge without intervention.  Otherwise - if code was changed, deleted or otherwise determined by git to require your attention, git will place markups around your changes and what is in the destination branch; simply delete the code that is no longer needed.  The markup something looks like this:

<<<<<<< Head </br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<i>Code from your local branch</i> 
</br>.=======</br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<i>Code from destination branch</i> 
</br>.>>>>>>> <i>Info about file</i> </br></br>

Read More: http://stackoverflow.com/questions/7901864/git-conflict-markers

- <b>Commits</b> tell your local repository/branch to save your current state.  You should include comments about what work you have done when you go to commit; your title should include a short summary of what was done.  Look at my repositories for examples. NOTE that this will not update the cloud, so collaborators will not see this until you push.
- <b>Pushing</b> a branch updates the remote (cloud) branch with you updates, including all commits. Before committing, you will need to set your origin branch - see Git console [TODO: find out if this is necessary via gui]
- <b>Issues</b> are basically TODO's for the projecet.  They include summaries of what should be done and potential psuedocode.  These issues can be assigned to collaborators to efficiently split tasks.  A good practice is to name your branch after an issue (if used) so that collaborators may follow what work you are doing.
- <b>Pull Requets</b> are requests to merge your code into branches.  We <i>may</i> use this to merge into master, essentially allowing collaborators a chance to test your code for bugs before merging. A good practice may involve one person in charge of accepting/denying these requests to streamline the process.
- <b>Fast Forward Merging</b> involves merging the destination branch <i>into</i> your local branch.  Here, you resolve conflicts, commit, then push.  This will be noted by Git, which will automatically "fast forward" your merge into destination (seeing as you have already resolved conflicts).
- <b>gitignore</i> is a file that specifies the file types that will not be tracked, updated, or stored in the repository.  Examples of files that are ignored include executables or files created by compilation, as these files need to be created by the user's compiler.

<h2>Github for Windows</h2>
-
Git provides a GUI for windows and other platforms that does the legwork of the commands for you (see below for commands).  This reduces some functionality, but is easier to pick up and is, in most cases, sufficient.

To avoid trying to describe the location of each of these features, I suggest looking up a tutorial of working this GUI (with pictures! :D).
</br>E.g. https://help.github.com/desktop/

<b>Download:</b> https://desktop.github.com/

<h2>Github Console</h2>
-
Vanilla git is command line coding of changes.  Each line begins with a 'git', followed by the commands you need to run (commit, fetch, merge, push, etc.).  While not the most intuitive setup, it does allow you to access every feature available in every command. The choice to use the GUI vs Console is a mixture of personal preference and current need, so use whatever you feel led to do.  If you need help, just ask.

<h3>Some Useful Commands</h3>
=
<b>NOTE</b> any commands in {} are optional.  See their individual explanations.

- git commit {-a}</br>
    - Commits the current branch. </br>
    - {-a} adds files not currently track and not in the .gitignore.
- git push {--set-upstream origin <i>target</i>} {origin}
    - Pushes recent commits to cloud repository.<br>
    - {--set-upstream origin <i>target</i>} sets the <i>target</i> branch in  the cloud as the origin for this branch's pushes; that is, all pushes will update the <i>target</i> branch. This is only a setup step, run once.<br>
    - {origin} specifies pushing to the cloud.  
- git status<br>
    - provides the status of your branch, including:
      - How many commits you are in front of the remote branch
      - Any tracked files that were changed
      - Any untracked files that can be added with git commit -a, or git add
- git add <i>file</i>
    - Adds <i>file</i> to tracked list; any untracked items will not be stored on the cloud.
      - You may recieve warnings that files are untracked; these warnings provide the commands necessary to add the files.
      - You must include file extension in the command.
- git fetch 
    - fetches the remote branch and updates (overwrites) your local branch with the changes. Useful for updating your local master branch with the remote - used in FF merging.
- git reset {-hard}
    - resets local branch with the remote data.
    - {-hard} completely discards all changes. If you royally screw your branch, you can use this to start fresh.

<b>Note:</b> Again, these are just basic commands to help you get started.  Each command listed has <i>many</i> more commands, but most are not necesary for our purposes.  Also, my explanations are generalizations with some assumptions and are potentially mistated; refer to the git documentation for the full list and official descriptions.
https://git-scm.com/doc

<h2>Getting Started</h2>
-
todo
