# Web API RestFull and JavaScript Test

## Getting Started

Clonar repositorio para descargar el proyecto de web api y el test de java script

### Prerequisites

Visual studio 2015, IIS y una base de datos SQL server

### Installing

1- Correr script para crear la base de datos, tablas y datos dummy alojado dentro de WebApi/Scripts <br/>
2- Modificar archivo Web.Config: Se utilizó Entity Framework para la capa de persistencia. Cambiar dentro de connection string la instancia de SQL server para apuntar a la base de datos SQL server local <br/> 

3- Correr Web Api desde visual studio <br/>
4- Se utilizó Rest Client para generar los request hacia los servicios expuestos <br/>

## Running the tests

Para correr los unit test: Menu Test -> Run All Test

### API y contracts

(GET) {locahost}/MyRestfullApp/Cotizacion/Moneda/{currency} -> Para obtener la cotizacion actual <br/>
(GET) {localhost}/MyRestfullApp/Users/GetUsers -> Para obtener todos los usuarios <br/>
(POST) {localhost}/MyRestfullApp/Users/CreateUser -> Para crear un usuario <br/>
(POST) {localhost}/MyRestfullApp/Users/UpdateUser/{id} -> Para actualizar un usuario en base a un id de usuario <br/>
(POST) {localhost}/MyRestfullApp/Users/DeleteUser/{id} -> Para borrar un usuario en base a un id de usuario

JSON para actualizar o crear un usuario:

{
  "LastName" : "a lastname",
  "FirstName" : "a firstname",
  "Email" : "a email",
  "UserPassword" : "a password"
}

### Test Javascript

1 - Descargar repositorio <br/>
2 - Correr archivo HTML para visualizar todos los ejercicios
