# README - Application .NET avec MongoDB

## Configuration requise

- .NET SDK
- MongoDB

## Installation

1. Clonez ce dépôt sur votre machine locale :

   ```
   git clone git@github.com:Amadoubenthe/AssociationDokent.git
   ```

2. Accédez au répertoire du projet :

   ```
   cd AssociationDokent
   ```

3. Restaurez les packages NuGet :

   ```
   dotnet restore
   ```

4. Configurez la connexion à MongoDB :

   - Ouvrez le fichier `appsettings.json`.
   - Modifiez la valeur de la clé `"MongoDBConnectionString"` en remplaçant `your_connection_string` par votre propre chaîne de connexion MongoDB.
