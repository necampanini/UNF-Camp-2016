## 2016 UNF Git Walkthrough

Preparing your environment
------

### Step 1 - Git Some
* Before anything, go here:
* https://git-scm.com/downloads
* Git is something running on your computer. Not a website.
* You will interact with it in order to save and share work.
* Installer defaults are fine.

### Step 2 - Git Bash
* If you are unfamiliar with a terminal, DO NOT SKIP THIS.
* (I'll use the words terminal, Git Bash, and command line interchangeably)
* You need to know 2 basic commands while operating in the terminal:
1. cd - 'see dee'
2. ls - 'elle ess'
* 'cd' is short for 'change directory'.
* 'ls' is short for 'list segments'. You'll use it to see the contents of the directory you're currently in.
* Both can be explicit or context based.
* You will use these to move around your folder structure and orientate yourself.
* Type the following in the terminal, pressing enter after each line.

```
mkdir /c/Projects
cd /c/Projects
pwd
```

### Step 2.5 - Git Bash More

* Never hesitate to type pwd or ls. Always know where you are operating.
* Keep going:

```
mkdir GitDemo
cd GitDemo
pwd
```

* You just made an empty folder called Projects at the root level of your C drive.
* You then changed the directory Git Bash is looking at, to said Projects folder.
* This isn't necessary. You can have your repositories anywhere on your system.
* This is a convention and one I recommend using.

* Then you made another folder in the Projects folder named GitDemo
* You cd'd in to it, and printed the working directory to confirm where you are.

### Step 3 - Git Hub
* Sign up for a Github account.
* Remember your username and password.
* Give me your GitHub user name. Do it.
* Wait for everyone to have given me their usernames.
* In the meanwhile, go here: https://www.sublimetext.com/
* Download and install the Sublime Text editor. A lightweight versatile text editor.
* Defaults are fine. Add Sublime option to right click context if desired.
* Wait for me to enter in everyone's usernames as Collaborators on the following project:
* Navigate here: https://github.com/necampanini/UNF-Camp-2016
* Find the clone/download link. (Hint, the button is big and green)


Pulling Down A Repository
-------------------------
### Step 3.5 - Git To Know You.
* Git doesn't know who you are.
* You will be unable to make commits and Git like that until it does.
* The minimum it needs to know is your name and email.
* This information is attached to your git operations and commits.
* So, give it that information (provide your own, not mine)

```
git config --global user.name "Nick Campanini"
git config --global user.email nick@feature23.com
```


### Step 4 - Git Clone
* Back to grabbing some code! Type:

```
pwd
```

* pwd is short for: 'print working directory'
* Git Bash should spit out '/c/Projects/GitDemo'
* If it doesn't, go back to Step 2 to try again.
* After ensuring you are in the correct directory...
* Ensure you have the GitHub repository URL copied
* (hit that big green button and click the little clipboard)
* Back in Git Bash, type the following:

```
git clone {insert key}
```

* Please actually hit the Insert key.
* This is a shortcut to paste what you have copied from the GitHub page.

* Hit enter and if everything's in order, Git Bash will clone a repository on to your local machine!

### Step 5 - What the Git?
* What's this mean?
* If you use the ls command, you'll see that there is a new folder named 'UNF-Camp-2016'
* You now have a copy of this project. The entirety of it. All of it's history.
* Every committed line of code, every message, literally all recorded history that makes up the project.
* This is the case for every project you clone via Git.
* Wow!

* What's more, is that since you cloned this git repository, git know's its roots.
* Since I've added you all as collaborators to this git project via GitHub...
* ...you can now push new commits and branches with full rights.
* Please don't abuse this priveledge.

### Step 6 - Git Out And Do
* Open Sublime.
* Should be blank!
* Click Project > Add Folder To Project
* Add: /c/Projects/GitDemo/UNF-Camp-2016
* Navigate to: Source Control/Students/Index.html
* In Folder Explorer of Sublime, right click that Index.html
* Click 'Open Containing Folder'
* Right Click Index.html and Open With a web browser (chrome, firefox, etc)

### Step 7 - Same Old Git
* Back in Git Bash, type:

```
git status
```

* Type this ALL THE TIME.
* This tell you the current status of your git operations
* When files modified, what files are ready to be committed, what NEW files git has detected.
* Take a minute to go find your respective student slot.
* Enter your name.

* In Git Bash, type another 'git status'

### Step 8 - Modify This Git
* RED. The files you change will appear under MODIFIED when you ask git for its status.
* Right now, git will NOT save this change even if you have it saved on your harddrive.
* Git will only make a 'COMMIT' when modified files are STAGED.
* Check out power point image of Git Life Cycle

* Add that file to the staging area:

```
git add Source Control/Students/index.html
```

* Use git status to see the new staged file.
* GREEN!
* Now you are ready to make a commit.

### Step 9 - Git There
* Git commits require a message, that you will pass in with "-m"
* Keep it short and to the point.
* Use the following as an example and make the commit:

```
git commit -m "added my name to index.html"
```

* Now let's walk through the student list and push/Pulling

### Step 10 - Git Storm
* Always use Git Status and Git Pull before attempting to Git Push
