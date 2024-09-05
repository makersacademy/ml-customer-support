Whenever I, as a leader, have asked myself 'how did I let this happen!' the answer is often 'one day at a time'. A great deal of technical leadership is recognising the subtle signs that something is awry and proactively managing it.

There's a tool for training this called a Decision Making Exercise. They can also be pretty fun! Here's one:

**Meet Simo: lead engineer, steady hand, tea enthusiast.**

Simo has been with the company for 14 years — a long time by any measure. He’s worked on it all, from the big legacy codebases that underpin the business to the modern satellite tech stacks that now orbit the central platforms, providing new features and products.

He’s been leading his current team for 6 months, prototyping a new CRM for high-value business customers that integrates via an API layer with 2 other existing tools and a third-party SaaS platform. The tech stack is primarily C# in the back end with two small services written in Java, and a React front end. The prototype has been a huge success and is being ramped up into a full production product, with Simo at the helm.

So far, the team has been relatively small and senior. Simo has been working closely with:

**Jack:** a senior frontend engineer.

**Marissa:** a very experienced full-stack engineer who has been primarily focused on API integrations. 

They’ve been supported by a BA and a shared PM resource. Because of the seniority in the team, they’ve been able to work relatively closely and quickly, with two particular advantages: two members of the team (Simo and Jack) have permissions to review and merge PRs, and they’ve built a test suite with very high coverage, which has ensured their defect rate and cycle time have been pleasingly low, even with reliance on external test resources. Because of this, they’ve built up a reliable cadence of work, committing to ambitious sprints and generally meeting their commitments.

---

### **The Ramp Up**

In order to scale up the application and integrate it properly with the rest of the ecosystem, the team is being expanded with 3 new engineers:

**Jedd:** a junior C# engineer who joined through a grad scheme and has been with the business for 18 months.

**Eva:** a junior front-end developer and bootcamp grad who has just joined the company after 12 months at a startup.

**Vaidas:** a mid-level Java engineer that Simo has been line-managing for the last 18 months.

What follows are events that occur during the first 5 months of the expanded team working on the project. Your task is to read each event in sequential order — without skipping ahead! As you do, mark down on paper or digitally which events seem significant to the successful completion of Simo's project. Put yourself in Simo's shoes: what would you do in response to the events that appear significant to you? How can you ensure the best possible chance of success? Note those thoughts down.

---

### **Sprint 1**

<details><summary>Event 1</summary>
</br>
The expanded team commits tickets to their first sprint. They include some easy starters for the new team members and some more complex work that Jack and Marissa are excited to get stuck into.
</details>

<details><summary>Event 2</summary>
</br>
Jedd submits his first PR, a simple update. Simo reviews it and notices some inconsistencies with the team's coding style as well as some missing tests. He leaves a list of comments for Jedd to fix and assigns it back to him.
</details>


---

### **Sprint 2**

<details><summary>Event 3</summary>

As the sprint progresses, Eva is struggling setting up her local development environment reliably and spends most of her time on Stack Overflow and ChatGPT, falling behind on her tickets.
</details>


<details><summary>Event 4</summary>
</br>
Marissa is asked to urgently fix a critical bug in another project, pulling her away from her assigned tasks for the sprint. The team still manages to meet their commitment, just.
</details>


---

### **Sprint 3**

<details><summary>Event 5</summary>
</br>

Jedd privately complains to Eva that Simo’s tone on pull request reviews is rude and that he feels some imposter syndrome. Eva mentions she’s struggling too and hasn’t been able to focus much on coding because of her setup issues.
</details>


<details><summary>Event 6</summary>
</br>

The impact of Eva's setup issues and Marissa's absence becomes clear as the team misses their sprint commitment for the first time, completing 80% of planned work.
</details>


---

### **Sprint 4**

<details><summary>Event 7</summary>
</br>

Marissa returns to find Eva has picked up one of her in-progress tickets but has struggled to make much progress, left some requirements half finished and abandoned it again. She hides her frustration.
</details>


<details><summary>Event 8</summary>
</br>

Vaidas opens a PR, and one test unexpectedly causes the suite to fail. When he re-runs the suite a third time, it passes. The PR gets approved and merged.
</details>


<details><summary>Event 9</summary>
</br>

Simo notices that the cycle time for tickets with the external QA team has increased. The delays are minor but he’s worried.
</details>


<details><summary>Event 10</summary>
</br>

At the end of the sprint, Jack mentions in a standup that he’s blocked on three tickets that are waiting for review and will need to carry them over. Simo has to carry the meeting as the rest of the team are quiet.
</details>

---

### **Sprint 5**

<details><summary>Event 11</summary>
</br>

At the midpoint of the sprint, two of Jack’s tickets are still in review. The third goes to QA, but the cycle time has increased even more.
</details>


<details><summary>Event 12</summary>
</br>

Simo spends three evenings in a row staying late to catch up on code reviews and project management tasks. He’s careful not to share this with the team.
</details>


<details><summary>Event 13</summary>
</br>

The team completes 85% of their tickets.
</details>


---

### **Sprint 6**

<details><summary>Event 14</summary>
</br>

The team releases their work into production, and the application falls over. Simo and Marissa spend a late night debugging and discover a subtle timezone discrepancy that has caused a 500 error in the API, bringing the whole app down.
</details>


<details><summary>Event 15</summary>
</br>

Following a washup, Simo implements a new code review policy, requiring at least two reviewers per PR in order to catch bugs before they’re merged. 
</details>


---

### **Sprint 7**

<details><summary>Event 16</summary>
</br>

Jack and Eva have a disagreement over the best approach to a complex UI problem. The debate gets heated, and Simo has to step in to mediate.
</details>


<details><summary>Event 17</summary>
</br>

Jack reports in standup that he has 4 tickets in QA, all waiting for feedback. Simo suggests he use the time to add reviews to PRs that are mounting up. 
</details>

---

### **Sprint 8**

<details><summary>Event 18</summary>
</br>

Mid-sprint, the team gets a last-minute request from upper management to add a new feature for a client demo. They reprioritise the sprint to allow time for Marissa and Jack to work on it.
</details>

---

### **Sprint 9**

<details><summary>Event 19</summary>
</br>

Jedd accidentally commits his work directly to main, causing both Marissa and Jack to end up with unexpected conflicts in their feature branches that need resolving. Marissa seems particularly frustrated, and the rework pushes the sprint timeline dangerously close to the deadline.
</details>


<details><summary>Event 20</summary>
</br>

Jack's disengagement becomes more apparent as he spends less time on reviews and more time on what seems to be personal projects or distractions.
</details>

---

### **Sprint 10**

<details><summary>Event 21</summary>
</br>

Jack drops a bombshell: he's accepted a job offer elsewhere and will be leaving the company in four weeks. Simo immediately thinks about how much of the frontend work depends on Jack.
</details>


<details><summary>Event 22</summary>
</br>

The team misses their sprint commitment, completing only 60% of the points committed.
</details>

---

<details><summary>Questions</summary>
</br>

What are the prospects for the project now?

Look back on your notes — when did you first notice the risks? And when did you realise they were going to be this damaging? Were your responses proportionate?
</details>
