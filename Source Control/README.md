## 2016 UNF Git Walkthrough

Preparing your environment
------

### Step 1 - Git Some
* Git is something running on your computer. Not a website.
* You will interact with it in order to save and share work.
* Go download it here for your respective operating system:
* https://git-scm.com/downloads
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

* Then you made another folder in the Projects folder, then moved into it.
* Finally, you printed the working directory to verify your location.

### Step 3 - Git Hub
* Sign up for a Github account.
* Remember your username and password.
* Give me your GitHub user name. Do it.
* Wait for everyone to have given me their usernames.
* Wait for me to enter in everyone's usernames as Collaborators on the following project:
* Navigate here: https://github.com/necampanini/UNF-Camp-2016
* Find the clone/download link. (Hint, the button is big and green) 


Pulling Down A Repository
-------------------------
### Step 3.5 - Git More
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
* Git Bash should spit out '/c/Projects'
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