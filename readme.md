# Playground de ASP.NET MVC 5 + DDD + EF + AutoMapper + IoC #

[Tutorial - Eduardo Pires](https://www.eduardopires.net.br/2014/10/tutorial-asp-net-mvc-5-ddd-ef-automapper-ioc-dicas-e-truques/)

### Conteúdo abordado no tutorial

* Criar uma solução padrão DDD
* Separar a aplicação em camadas
* Entidades de Domínio
* Classes de Serviço
* Criar Contratos (Interfaces)
* Repositório Genérico
* Repositório Especializado
* Criar um Contexto do Entity Framework
* Trabalhar com Migrations
* Criar novas convenções do Entity Framework
* Remover algumas convenções do Entity Framework
* Sobrescrever o método SaveChanges para persistência de dados
* Programar com CodeFirst
* Utilizar FluentAPI para modelar tabelas
* Criar Relacionamentos entre Entidades e refletindo nas tabelas do banco de dados.
* Criar e utilizar a camada de Application
* Trabalhar com classes genéricas de Entidades
* Abstrair camadas com Injeção de Dependência (IoC)
* Implementar o Ninject como container de IoC (DI)
* Utilizar ViewModels
* Utilizar DataAnnotations para validação de formulários
* Mapear ViewModels x Entidade de Domínio com AutoMapper
* Muitas dicas para acelerar sua produção


### Modelo de Arquitetura MVC
* ASP.NET MVC é apenas camada de apresentação.
* O padrão MVC visa apenas a separação de responsabilidades e nada mais.

### DDD - Domain Driven Design
* Uma abordagem de design.
* Complexa (no início).
* Desenvolvimento guiado pelo Domínio.
* Isolamento de Responsabilidades.
* Abstração de Camadas.

### Domain Layer
* Entidades.
* Objetos de Valor.
* Contratos (Interfaces).
* Services.
* Factories.

Montando uma aplicação utilizando ASP.NET MVC e aplicando DDD para guiar o desenvolvimento, com ORM's, Repositórios, IoC, mapeando as Entidades de Domínio com as ViewModels e entre outros patterns.  
A aplicação será:
* Responsável (por isolar todas as dependências, cada coisa reponder por si própria, não misturar os assuntos). 
* Escalável. 
* Testável. 
* Reutilizável  

E a somatória destes pontos torna a manutenção da aplicação muito mais fácil e tranquila.