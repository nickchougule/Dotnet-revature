# Dotnet-revature


1.ls  = lists all files in your curr working directory
2.ls -l  = provides a detailed list
3.ls -al  = Shows hidden files and directories
4.pwd  = print working directory(tells you your current location in the file system )
5.cd  = "change directory" navigates between directories
6.cd /  = Goes to the root of the file system.
7.cd ..  = jumps back one directory
8.cd  = Takes you back home
9.touch  = Creates a new, empty file. You can create multiple files at once.
10.echo  = Prints text to the terminal. Can also be used to add text to a file using > (redirect) or >> (append)
11.nano  = A simple and user-friendly text editor. 
          nano [filename]: Opens the file for editing. 
          Ctrl + X: Exit the editor.
          Y: Confirm saving changes.
          Enter: Confirm the filename.
12.vim = A powerful but more complex text editor (often for advanced users).
            Usage:
            vim [filename]: Opens the file.
            i: Start inserting text (insert mode).
            Esc: Exit insert mode.
            :wq: Write (save) and quit the file.
13.cat [filename]  = Used to see what's inside a file really quickly.
14.shred [filename]  = Securely deletes a file so no one can ever see its content.
15.mkdir [directory_name]  = "Make Directory" — creates a new directory.
16.cp [source_file] [destination]  = "Copy" — copies a file to a specified destination.
17.mv [source_file] [destination]  =  "Move" — moves or renames a file.
18.rm  = "Remove" — deletes a file.
          rm [filename]: Deletes a file.
          rm -r [directory_name]: Deletes a non-empty directory recursively.
19.rmdir [directory_name]  =  "Remove Directory" — deletes an empty directory.
20.ln -s [target_file] [link_name]  = "Link" — creates a link (shortcut) to a file. (creates a soft link).
21.clear  = Cleans off your terminal screen.
22.whoami  = Tells you your current username.
23. useradd [username] (requires sudo prefix if not root)  = Creates a new user account (often requires sudo)
24.sudo  = "SuperUser Do" — allows you to execute commands with root privileges. Prepend sudo before the command                (e.g., sudo useradd [username]). You'll need to enter your password.
25.sudo adduser [username]  = An interactive command to create a new user, allowing you to set parameters like passwords.
26.su [username] = "Switch User" — switches to another user account.
27.exit  = Exits the current shell session or switches back from a different user.
28.passwd  = Changes a user's password.
           passwd [username]: Changes the password for a specific user.
           passwd: Changes your own password.
29.apt  =Package manager for Debian-based systems (like Ubuntu) for installing and updating software.
         sudo apt update: Updates the package repositories.
         sudo apt install [package_name]: Installs a specific package.
30.finger  = Inspects information about another user (requires installation via apt).
            finger [username]: Displays user information.
31.man  = "Manual" — helps you find out what a command does by showing its manual page.
         man [command_name]: Displays the manual page.
         Q: Quit the manual page.
32.whatis  = A faster way to get a quick description of a command.
             whatis [command_name]: Displays a brief description.
33.which = Tells you where a specific command's executable file is located.
             which [command_name]: Shows the path to the command's executable.
34.whereis = Tells you where all instances of a command (binary, source, manual) are located.
whereis [command_name]: Shows all locations of the command.
35.wget = Helps you get stuff from the internet, like downloading files.
wget [URL]: Downloads a file from the URL.
36.curl = Another tool for downloading from the internet; a personal favorite.
curl [URL] > [output_filename]: Downloads and writes to a file.
37.zip = Compresses files into a .zip archive.
zip [output_zip_file_name] [files_to_zip]: Compresses specified files.
38.unzip = Extracts files from a .zip archive.
unzip [zip_file_name]: Extracts files from the archive.
39.less = Allows you to read large files one page at a time.
less [filename]: Opens the file for paging.
40.head = Shows only the beginning (top) of a file.
head [filename]: Displays the start of the file.
41.tail = Shows only the end (bottom) of a file.
tail [filename]: Displays the end of the file.
42.cmp = "Compare" — compares two files to see if they are the same. It indicates if there's a difference.
cmp [file1] [file2]: Compares two files.
43.diff = "Difference" — compares two files and tells you exactly what the differences are.
diff [file1] [file2]: Shows differences between files.
44.sort = Sorts text (e.g., lines in a file) alphabetically.
cat [file] | sort: Sorts content piped from a file.
45.find = Locates files based on various criteria (e.g., name, type, location).
find [directory_to_search] -name "[pattern]": Finds files matching a pattern.
46.chmod = "Change Mode" — changes file permissions (e.g., making a file executable).
chmod +X [filename]: Adds execute permission.
47.chown = "Change Ownership" — changes the owner of a file.
chown [new_owner_username] [filename]: Changes file ownership.
48.ifconfig = Displays network interface configuration, including IP address.
ifconfig: Shows network interface details.
49.ip address = A more modern command to display network interface configuration.
ip address: Shows network interface details.
50.grep = Searches for specific text patterns within files or command output.
[command_output] | grep "[pattern]": Filters command output for a pattern.
51.awk = A powerful text processing tool for advanced pattern matching and formatting.
[command_output] | awk '{print $field_number}': Processes text for specific fields.
52.resolvectl status = Shows DNS server status on newer Linux distributions.
resolvectl status: Displays DNS resolver information.
53.ping = Tests network connectivity to a host.
ping [hostname_or_IP_address]: Sends continuous pings.
ping -c [count] [hostname_or_IP_address]: Sends a specific number of pings.
-s [size]: Specifies the size of the packets.
54.traceroute = Shows the path (hops) that packets take to reach a website.
traceroute [hostname_or_IP_address]: Traces the network path.
55.netstat = "Network Statistics" — displays network connections, routing tables, and interface statistics.
netstat -tulipn: Shows listening TCP/UDP ports with process IDs and numeric addresses.
56.ss = "Socket Statistics" — a more modern and faster version of netstat.
ss -tulipn: Shows socket statistics.
57.iptables = A complex command-line utility for configuring the Linux kernel firewall.
sudo iptables -A INPUT -p tcp --dport 80 -j ACCEPT: Example of allowing port 80.
58.ufw = "Uncomplicated Firewall" — a simpler front-end for iptables to manage the firewall easily.
sudo ufw allow [port]: Allows incoming traffic on a port.
ufw status: Shows current firewall status and rules.
sudo ufw enable: Enables the UFW firewall.
59.uname = "Unix Name" — displays basic system information.
uname: Shows basic kernel name.
uname -a: Shows all available system information.
60.neofetch = Displays system information in a visually appealing ASCII art format (requires installation).
sudo apt install neofetch: Installs neofetch.
neofetch: Runs neofetch.
61.cal = Displays a calendar.
cal: Displays the calendar.
sudo apt install ncal: Installs the calendar utility.
62.free = Checks on your memory and see how much memory is available.
free: Displays memory usage.
63.df = "Disk Free" — displays disk space usage of file systems.
df -h: Shows human-readable disk space.
64.ps = "Process Status" — displays information about running processes.
ps aux: Shows all processes running on the system.
65.top = Displays a real-time, dynamic view of running processes and system resource usage.
top: Runs the top utility.
66.htop = A prettier and more interactive version of top (requires installation).
htop: Runs the htop utility.
67.kill = Sends a signal to terminate a process by its process ID (PID).
kill -9 [PID]: Forcefully kills the process.
68.pkill = Kills processes by name, without needing to know the process ID.
pkill -f [process_name]: Kills processes by name.
69.systemctl = Controls and manages systemd services (start, stop, restart, status).
sudo systemctl stop [service_name]: Stops a service.
sudo systemctl start [service_name]: Starts a service.
systemctl status [service_name]: Shows service status.
sudo systemctl restart [service_name]: Restarts a service.
70.history = Displays a history of all previously executed commands.
history: Displays command history.
71.reboot = Restarts the system.
sudo reboot: Reboots the system.
72.shutdown = Shuts down the system.
sudo shutdown: Shuts down in about one minute.
sudo shutdown -h now: Shuts down immediately.
taken from-https://www.youtube.com/watch?v=gd7BXuUQ91w
 


