
# MonoTestSolution
MonoTestSolution displays a list of vehicle makes.It also shows different models for each vehicle make.

* Screenshots

<p align="center">
<img src="https://github.com/Carlosokumu/MonoTestSolution/blob/master/screenshots/vehiclemakelist-dark.png" width="30%" height="35%"/>
<img src="https://github.com/Carlosokumu/MonoTestSolution/blob/master/screenshots/makelist-light.png" width="30%" height="35%"/>
<img src="https://github.com/Carlosokumu/MonoTestSolution/blob/master/screenshots/makedetailsdark.png" width="30%" height="35%"/>
<img src="https://github.com/Carlosokumu/MonoTestSolution/blob/master/screenshots/makedetailslight.png" width="30%" height="35%"/>
<img src="https://github.com/Carlosokumu/MonoTestSolution/blob/master/screenshots/vehiclemakesearch.png" width="30%" height="35%"/>
</p>

* Notable Packages Used
    * [Automapper](https://docs.automapper.org/en/stable/Getting-started.html) 
    * [Autofac](https://autofac.readthedocs.io/en/latest/getting-started/index.html)
    * [Sqlite-net-plc](https://github.com/praeclarum/sqlite-net)
  
 * Architecture
      * Repository Layer - Contains the Dtos,Database Tables for the Entities and makes api calls
      * Service Layer - Contains the different models used by the UI and also the mapping mechanism between  it and the Repository Layer
      <p align="center"><img src="https://github.com/Carlosokumu/MonoTestSolution/blob/master/screenshots/architecture.png" width="70%" height="70%"/> 
      </p>

