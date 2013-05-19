Ultra Keylogger Plus+
=====

When I was in a sophomore in high school (about 2010), a kid asked me to make a keylogger, and he'd pay me $100. The broke programmer that I was (and still is), accepted.

You probably know the end of this story, he never paid up, so I never gave it to him.

Information
---

I wrote this in C#, and it uses native global Win32 keyboard hooks, and some low level Win32 API stuff like making a process critical.

There are 4 files used by the keylogger:

* email.krs - which is the email to send the logs to
* keywords.krs - which are keywords that trigger the email sender
* logs.krs - the logs that store the keystrokes
* secret.krs - the password to access the program.

This keylogger has code that sends emails, so you must modify the method sendMailK in MainForm.cs, and the method sendEmail in mainForm.cs (for SetupWizard) to set up the email account that sends the log, it uses a Gmail account by default.

License
---
```
Copyright (c) 2010-2013, Joshua Kennedy
All rights reserved.

Redistribution and use in source and binary forms, with or without
modification, are permitted provided that the following conditions are met:
    * Redistributions of source code must retain the above copyright
      notice, this list of conditions and the following disclaimer.
    * Redistributions in binary form must reproduce the above copyright
      notice, this list of conditions and the following disclaimer in the
      documentation and/or other materials provided with the distribution.
    * Neither the name of the <organization> nor the
      names of its contributors may be used to endorse or promote products
      derived from this software without specific prior written permission.

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
DISCLAIMED. IN NO EVENT SHALL <COPYRIGHT HOLDER> BE LIABLE FOR ANY
DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
(INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
(INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE
```
