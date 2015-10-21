<b>NOTE:</b> This is meant to cover the basics and some commands.

<h1>About Github</h1>
Github is a file and source sharing site that allows multiple developers to collaborate on a single project.

In pursuit of this, Git provides a suite of features that allows us to work separately, afterwards cleanly merge the changes.  This process is known as <i>forking</i>.  Forking a repository creates your own little <i>branch</i> from which to work on.  Each branch has its own copy of the source code, allowing you to work without a collaborator's changes interfering.  Once work completes for a branch, we do what is called a <i>merge</i>.  
Merging takes a source branch and syncs changes with a destination branch.  In some cases, discrepencies which do not allow clean merges must be resolved. At these points, Git will place simple markups in the code that shows the difference.  The user chooses the code to be kept and deletes the rest.  Afterwards, git will merge the changes such that each branch has the same source.
