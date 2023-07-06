# Wonderful Store

### Decisões tecnicas e arquiteturais

    - Decidi utilizar o padrão de Arquitetura Limpa durante o desenvolvimento, pois é uma padrão bastante completo. Ajuda na legibilidade de todo o codigo
    - Utilizou-se os principais principios do DDD. Entitidades ricas e que regram todo a regra de negocio do sistema.
    - Principios Codigo-Limpo: Foi utilizado os principios do codigo limpo para ajudar na coesa e legibilidade do codigo.
    - Principios SOLID: Utilizou-se todos os principios do SOLID(Single Responsiblity Principle, ,Open-Closed Principle,  Liskov Substitution Principle,Interface Segregation Principle, Dependency Inversion Principle) durante o desenvolvimento do sistema. Já que traz coesão e legibidalidade para todo o codigo.
    - Utilizei design patterns que podiam me ajudar na solução os problemas encontrados. Os principais foram eles: Factory Method, Builder, Mediator e Command.
    - Utilizei o padrão CQRS para facilitar na orquestrão das rotas e legibilidade.
    - Obdece Inversão de dependencia
    - Utiliza padrão de repositorio
    - Utilizei o Enum PromotionType para armazenar a promoção do produto.
    

### Justificativa dos framworks e bibliotecas

    - ASP.NET: Trata-se de uma ferrameta essencial para o desenvolvimento de sistema escalonavéis. Sua performace e padrões facilitam o processo de criação de um bom sistema.
    - Utilizei o Entity Framework para orquestração do banco de dados SQL server, pois possui facilidade durante seu uso no desenvolvimento e possui grande perfomace
    - Mediator: Utilizado para o padrão CQRS
    


### instrução de como compilar e executar o projeto

    - Dentro de appsetiings, coloque sua connectionString do SQL Server dentro do campo WonderfulStoreDatabase. Exemplo: "Server=localhost; Database=wonderfulStoreDb; Integrated Security=True; trustServerCertificate=true"
 
    ```bash 
    
    $ git clone https://github.com/flaviomanuel/wonderfulStore.Api
    
    $ cd wonderfulStore.Api
    
    $ dotnet restore

     $  cd ./WonderfulStore.Infrastructure

     # Para criar as tabelas dentro do banco de dados
     $ dotnet ef database update -s ../WonderfulStore.Api/WonderfulStore.Api.csproj

     $ cd ..

     $ cd ./WonderfulStore.Api

     $ dotnet run

    ```

    Acesse o link: http://localhost:5138/swagger/index.html

###  Praticas durante o desenvolvimento

    - Clean code
    - CQRS
    - DDD
    - Repository pattern
    - SOLID
    - Design patterns


