# ReadMe

## Project Goal
- Have a WPF Front End
- Have and SQL database backend with at least two linked tables
- Use Entity Framework to manage the relationship between your backend object model and database
- Have a Business Layer with some logic

**Create an application that stimulates your short term memory and stores the scores, allowing you to track your progress.**

## Definition of Done
- Code has been written
- Code has been tested
- Ensure code is compliant with user story requirement
- Acceptance criteria has been met
- Code has been documented and pushed to GitHub

## Class Diagrams



## Project Retrospective
- I think the overall process of the project went well.
- If I were to change my approach for the future I would have aimed to do the database content after the front-end.
> - This is because I had made errors when migrating the data initially so I had to remigrate and create the database several times over before I got it to work.
> - This would be important in a work environment as I was unable to provide a completed increment at the end of the sprint because of this.
- I think if I had more time beforehand to experience and experiment with WPF I would have been able to code the front-end a lot faster
> - At the end of the UI development during the last sprint I felt very comfortable with the commands and XAML in general. This would have been beneficial at the start of the project.
- Although I achieved the MVP I would have liked to have implemented the addition games I had formulated in my notes.
> - If I had made the changes mentioned above I likely would have had enough time to implement at least one of the additional games.
- I also would have liked to alter the leaderboard slightly as the column contents are not centred and there is not column displaying the difficulty of game the user had achieved the score at.

## Sprint Summaries

### Sprint 1
#### Sprint Goal
- Create the database and link the files together.
- Implement the user login system.

#### Backlog Items Completed
- None fully implemented.

#### Sprint Retrospective
- Re-evaluated the task criteria and changed the project towards the end of sprint in order to fully meet the criteria.
- This meant that most of the sprint was wasted trying to remake the project.
- Most of the databases have been created and linked.

#### Sprint Board
> - Before: ![Start of Sprint 1](C:\Users\Alex Rae\Documents\Sparta\Scrum Boards\Sprint 1\Sprint 1\Sprint 1 start.png)
> - After: ![End of Sprint 1](C:\Users\Alex Rae\Documents\Sparta\Scrum Boards\Sprint 1\Sprint 1\sprint 1 end.png)


### Sprint 2
#### Sprint Goal
- Finish creating the database.
- Finish the user login and account system.
- Ensure users registered are unique.

#### Backlog Items Completed
- Epic coded - Create a user login and account system.
  > - User can register new accounts with a username and password.
  > - Usernames must be unique.
  > - Users are stored in the User table.

- Epic coded - Create a database to store user's scores.
  > - User's scores are stored in the Scores table.
  > - A User can view the latest score they achieved.
  > - A User can view the highest score they have achieved.

#### Sprint Retrospective
- Luckily the login feature that I had started developing in sprint 1 was usable in the second sprint. This provided me with a foundation to store user scores.
- I have completed the entire backend, allowing me to start implementing it in the business layer.
- The tasks have been moved to review as the code to test it hasn't been completed yet.

#### Sprint Board
> - Before: ![Start of Sprint 1](C:\Users\Alex Rae\Documents\Sparta\Scrum Boards\Sprint 2\Sprint 2\sprint 2 start.png)
> - After: ![End of Sprint 1](C:\Users\Alex Rae\Documents\Sparta\Scrum Boards\Sprint 2Sprint 2\sprint 2 end.png)


### Sprint 3
#### Sprint Goal
- Create the first memory game to achieve the MVP.

#### Backlog Items Completed
- The main functionality of the game has been completed.
  > - The user will gain score for the correct answer and lose lives for the incorrect answer.
  > - When the game is over the user is taken to the leaderboard.

#### Sprint Retrospective
- Although the current UI is very basic the game is working as intended.
- Adding the score to the relevant User hasn't been implemented yet however.
- When taken to the leaderboard nothing is displayed.

#### Sprint Board
> - Before: ![Start of Sprint 1](C:\Users\Alex Rae\Documents\Sparta\Scrum Boards\Sprint 3\Sprint 3\sprint 3 start.png)
> - After: ![End of Sprint 1](C:\Users\Alex Rae\Documents\Sparta\Scrum Boards\Sprint 3\Sprint 3\sprint 3 end.png)

### Sprint 4
#### Sprint Goal
- Implement the score saving according to the user and display it in the leaderboard.
- Create a second difficulty for the memory game.

#### Backlog Items Completed
- Code has been completed for the second difficulty.
- Functionality of the leaderboard has been completed.

#### Sprint Retrospective
- Leaderboard is correctly showing the intended information however there is zero frontend completed for it making it currently unusable.

#### Sprint Board
> - Before: ![Start of Sprint 1](C:\Users\Alex Rae\Documents\Sparta\Scrum Boards\Sprint 4\Sprint 4\sprint 4 start.png)
> - After: ![End of Sprint 1](C:\Users\Alex Rae\Documents\Sparta\Scrum Boards\Sprint 4\Sprint 4\sprint 4 end.png)


### Sprint 5
#### Sprint Goal
- Make the leaderboard show the correct information and ensure it is readable.
- Make the leaderboard show the most recent score a user has achieved.
- Make the leaderboard show the highest score a user has achieved.

#### Backlog Items Completed
- Leaderboard is now fully functional and usable.
- Leaderboard shows Username, Latest Score and High Score.

#### Sprint Retrospective
- The MVP of the product has been completed.
- Ideally I would have liked to add another column that indicated which difficulty the user achieved the score at
  > Not sure if this is relevant as I don't know if it is harder to recall longer words compared to short words.
- I would have liked to implement the extra user stories but as there is only one sprint left there is not enough time.
- The final sprint will allow me to overhaul the front end and make it a usable product.

#### Sprint Board
> - Before: ![Start of Sprint 1](C:\Users\Alex Rae\Documents\Sparta\Scrum Boards\Sprint 5\Sprint 5\sprint 5 start.png)
> - After: ![End of Sprint 1](C:\Users\Alex Rae\Documents\Sparta\Scrum Boards\Sprint 5\Sprint 5\sprint 5 end.png)


### Sprint 6
#### Sprint Goal
- Redesign the front-end to make the product presentable for a hypothetical customer.

#### Backlog Items Completed
- Completed design overhaul

#### Sprint Retrospective
- I decided to change the dimensions of the app to better fit a small screen such as a phone.
  > - This decision was made because of the simplicity of the UI and overall game
  > - Having it spread out across an entire monitor overemphasised the empty space which is why the smaller form factor fit better.
- The only thing I would have liked to improve in this aspect was the centring of the contents in the leaderboard
  > The column headers are centred however the contents are not. I spent hours trying to fix this but could not find a solution.

#### Sprint Board
> - Before: ![Start of Sprint 1](C:\Users\Alex Rae\Documents\Sparta\Scrum Boards\Sprint 6\Sprint 6\sprint 6 start.png)
> - After: ![End of Sprint 1](C:\Users\Alex Rae\Documents\Sparta\Scrum Boards\Sprint 6\Sprint 6\sprint 6 end.png)


