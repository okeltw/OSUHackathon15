<b>NOTE:</b> This is meant to cover the basics and some commands.

<h1>About Github</h1>
-
Github is a file and source sharing site that allows multiple developers to collaborate on a single project.

In pursuit of this, Git provides a suite of features that allows us to work separately, afterwards cleanly merge the changes.  This process is known as <i>forking</i>.  Forking a repository creates your own little <i>branch</i> from which to work on.  Each branch has its own copy of the source code, allowing you to work without a collaborator's changes interfering.  Once work completes for a branch, we do what is called a <i>merge</i>.  
Merging takes a source branch and syncs changes with a destination branch.  In some cases, discrepencies which do not allow clean merges must be resolved. At these points, Git will place simple markups in the code that shows the difference.  The user chooses the code to be kept and deletes the rest.  Afterwards, git will merge the changes such that each branch has the same source.

<h2>Github Concepts</h2>
-
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

<h2>Github for Windows</h2>
-
Git provides a GUI for windows and other platforms that does the legwork of the commands for you (see below for commands).  This reduces some functionality, but is easier to pick up and is, in most cases, sufficient.

To avoid trying to describe the location of each of these features, I suggest looking up a tutorial of working this GUI (with pictures! :D).
</br>E.g. https://help.github.com/desktop/

<b>Download:</b> https://desktop.github.com/

<h2>Github Console</h2>
-
todo

<h2>Some Useful Commands</h2>
-
todo

<h2>Getting Started</h2>
-
todo
