_Repositório apenas para estudo_

# Curso: Construindo aplicações em Contextos Delimitados

Neste curso vamos aprender mais sobre a criação de aplicações em contextos delimitados.

Instrutor:

- [Yan de Lima Justino](https://balta.io/contribuidores/yan-justino)

Referências:

- https://balta.io/cursos/construindo-aplicacoes-em-contextos-delimitados
- https://github.com/yanjustino/5504
- https://www.infoq.com/br/presentations/bounded-context-e-cqrs-na-evolucao-de-aplicacoes-dotnet-legadas/

<br>
<br>

**Anotações**

## Conteúdo Programático

1. Introdução
   1. Fundamentos
   2. Modelagem estratégica
   3. Modelagem tática
   4. Arquitetura
2. Colocando a Mão na massa
   1. Introdução
   2. Entidades
   3. Objetos de valor
   4. Implementação
   5. Shared Kernel
3. Finalização
   1. Organização
   2. Composição de contextos

<br>
<hr>

**Anotações**

## 1.1 Fundamentos

### Construindo applicações baseadas em Bounded Context

[Artigo: Microsoft N Layer App Sample, Part II–getting lost in the architecture - Exemplo de aplicativo da camada N da Microsoft, parte II - se perdendo na arquitetura](https://ayende.com/blog/27649/review-microsoft-n-layer-app-sample-part-ii-getting-lost-in-the-architecture)

[Vídeo: Ruby Midwest 2011 - Keynote: Architecture the Lost Years by Robert Martin](https://www.youtube.com/watch?v=WpkDN78P884)

DDD é sobre a **Redução de complexidade no software** - Eric Evans

- Se arquitetura deixa seu software complexo demais, existe algum problema!

Arquitura é sobre **Intenção** - Robert C. Martin

- Se a solução não demonstração a inteção de resolver algo, existe algum problema!

[Good Design Is Imprefect Design](https://www.infoq.com/presentations/ddd-imperfect-design/)

### COMO DDD Gerencia complexidades?

1. **Destilando o Problema**
   - de domínio para revelar o que realmente importa
2. **Criando um modelo**
   - para resolver problemas de domínio
3. **Usando uma linguagem compartilhada**
   - para habilitar modelagem colaborativa
4. **Isolando Modelos**
   - de ambiguidade e corrupção
5. **Entendendo** a **Relação entre contextos**

## 1.2 Modelagem Estratégica

### Superfície do Problema

- Estragégia é dividir este problema em partes menortes

- Estas partes menores chamaremos de 'domínio' (domínio principal e subdominios)

- Cada subdominio é umm contexto de uma parte do problema em geral

- Cada subdominío tem sua linguagem específica, seus temos específicos.

- Como dividir em subdomínio?

### Destilando o Problema do Domínio

- **Mastigando** o conhecimento
  - colaboração
- Métodos para **imersão no conhecimento do domínio**
  - Conversas focadas no mais importante
    - Bussines Model Canvas
    - Perguntas poderosamente relevantes
  - Lista de casos de uso
  - Esboço
  - CRC (Class Responsibility Collaboration Cards)
  - Adiar a nomeação de conceitos em seu modelo
  - BDD
  - Prototipagem Rápida

### **Class Responsibility Collboration** Cards

É muito usada para abribuir responsabilidades durante o projeto.

- CRC - Class Responsibility Collaborations
- CRC cards inventadas por Ward Cunninghan e Kent Beck
  - Escreve-se o nome da classe, suas responsabilidades e colaborações
    - Só pense nas responsabilidades de alto nível
- São desenvolvidas em pequenos grupos em que cada pessoa assuma o papel (Role) de uma ou mais classes
- Mais detalhes aqui:
  - Designing Object-Oriented Software, Wirfs-Brock - Wilkerson e Viener; Prentice Hall, 1990. [Link](https://www.amazon.com/Designing-Object-Oriented-Wirfs-Brock-Wilkerson-Paperback/dp/B011DAR9A4)

Cartão **CRC** é um cartão pequeno (para somente escrever o essencial) para cada classe

### Behaviour-Driven Development

é uma técnica de desenvolvimento Ágil que encoraja colaboração entre desenvolvedores, setores de qualidade e pessoas não-técnicas ou de negócios num projeto de software, relaciona-se com o conceito de verificação e validação. Foi originalmente concebido em 2003, por Dan North como uma resposta à Test Driven Development (Desenvolvimento Guiado por Testes), e tem se expandido bastante nos últimos anos

**BetterSpecs**

Better Specs é uma coleção de melhores práticas que os desenvolvedores aprenderam ao testar aplicativos que você pode usar para melhorar suas habilidades de codificação ou simplesmente para se inspirar. Better Specs ganhou vida na Lelylan (plataforma de nuvem IoT de código aberto) e verificar seu conjunto de testes pode ser uma inspiração.

```bash
# .NET CLI
dotnet add package BetterSpecs

# Package Manager
Install-Package BetterSpecs
```

## 1.3 Modelagem Tática

### Superficie da solução

...

### Modelo de Negócio e Modelo de Domínio

_Imagem: 01-02 - 02 Modelo de negócio vs Modelo de Domínio_

- Cada subdominio tem uma visão particular, ou parte da visão de um produto

### Manifestação do Bolo de Lama

...

### Modelo de Domínio

- Cada contexto tem uma visão específica de um produto e o produto corresponde a uma linguagem específica de um modelo.

...

## 1.4 Aquitetura

### Bouded Context

- Também faz parte do Design do DDD

- Bounded context não é uma arquitetura, é uma estratégido do DDD

Estratégia:

- Isolar o subdomínio
- Dentro do subdomínio criar os contextos

Imagem

### Microservices: Finalmente Bounded Context

Imagem

### Bounded Context e Composite UI

Imagem

### Evoluindo sistemas legados com Bounded Context

Imagem

### Arquitetura Hexagonal

O melhor estilo arquitetural ele vai ser o estilo que resolverá o problema daquele contexto. Não existe bala e prata

Hexagonal conversa bem com o Bounded Context

## 2.1 Introdução

Bloco da Construção - Construindo Aplicações Baseadas em Bounded Context

**Propblema Proposto**

- Evento Certificado

**Problemática**

- Geralmente a **DISTRIBUIÇÃO DE CERTIFICADOS PARA EVENTOS** é um ponto muito crítuco: **cadastro, confecção, emissão** são áreas que demandasm muita atenção. Falhas em algum processo e de alguma dessas áreas podem compromenter o **prazo de entrega** destes certificados, deteriorando assim a relação entre **organização** e **participantes**, bem como compromentendo a imagem do evento perante seu público futuro. Sendo assim criar tecnologias que provomam **agilidade, segurança e transparência** para tal processo seria grande de valia para o setor de eventos.

**Requisitos:**

1. A plataforma deve permitir o cadastro de novos organizadores de eventos.
2. A plataforma deve permitir CADASTRAR e associar ao organiador um evento: Nome, data, horário, local, lista de palestras, duração total do evento e lista de partifipantes com nome completo, RG, CPF e email
3. A plataforma deve permitir a CONFECÇÃO de certificados para eventos. Essa confecção deve usar arquivos HTML e CSS
4. A plataforma deve permitir a EMISSÃO de certificado para cada participante de um evento através de um site onde o mesmo possa informar algum código para imprimir ou baixar o PDF do seu certificado.
5. A plataforma deve enviar e-mail para os participantes informando disponibilidade de certificados com o endereço, código de acesso e instruções para emissao! DEVE OBEDECER A DATA DE LIBERAÇÃO ESTIPULADA PELO ORGAIZADOR.
6. A plataforma deve possuir um serviço para validação do certificado.
7. A plataforma deve ter um relatório de certificados já emitidos!

Retomando a Estragétia

```bash
dotnet new sln -n EventoCertificado
```

## 2.2 Entidades

_Uma entidade é uma coisa única (**única identidade**) e capaz de ser mudado de forma contínua durante um longo período de tempo (Vernon)._

Geralmente a DISTRIBUIÇÃO DE CERTIFICADOS PARA EVENTOS é um ponto muito crítico: cadastro, confecção, emissão são áreas que demandam muita atenção. Falhas em algum processo de alguma dessas áreas podem comprometer o prazo de entrega destes certificados, deteriorando assim a relação entre ORGANIZAÇÃO e Participantes, bem como comprometendo a imagem do evento perante seu público futuro. Sendo assim, criar tecnologias que promovam agilidade, segurança e transparência para tal processo seria de grande valia para o setor de eventos.

**IDENTIDADE ÚNICA**

- **Usuário provendo identidade**
  - posts de blog
- **Aplicação provendo identidade**
  - uuid guid approach
- **Persistência gerando identidade**
  - delegando a mecanismo de persistência:orms,sgdbs
- **Identidade gerada por outros contextos delimitados**
  - verificação de integridade!

Como garnatir que a unicidade é preservada em todo o cíclo de vida de uma entidade?

## 2.3 Objetos de Valor

_Objetos de valor são um bloco vital do **DDD**. Exemplos comuns de modelagem destes objetos são numeros, textos, data, hora, objetos de composição (nome e sobrenome)_

Geralmente a DISTRIBUIÇÃO DE CERTIFICADOS PARA EVENTOS é um ponto muito crítico: cadastro, confecção, emissão são áreas que demandam muita atenção. Falhas em algum processo de alguma dessas áreas podem comprometer o **PRAZO DE ENTREGA** destes certificados, deteriorando assim a relação entre Organização e **PARTICIPANTES**, bem como comprometendo a imagem do evento perante seu público futuro. Sendo assim, criar tecnologias que promovam agilidade, segurança e transparência para tal processo seria de grande valia para o setor de eventos.

### MAS NÃO SÓ ISSO

- Fáceis de criar, testar, usar, otimizar e manter!
- Imutabilidade
- Integração Minimalista.
- devemos nos esforçar para modelar objetos usando os valores em vez de entidades sempre que possível.

GARNATINDO QUE A UNICIDADE SERÁ PRESERVADA EM TODO O CÍCLO DE
VIDA DE UMA ENTIDADE?

## 2.4 Implementação

_O agrupamento de entidades e objetos de valor em um agregado com um limite consistente e cuidadosamente trabalhado pode parecer à primeira vista como um trabalho fácil, mas entre todas as orientações táticas do DDD, esse padrão é um dos menos bem compreendidos._

Geralmente a DISTRIBUIÇÃO DE CERTIFICADOS PARA **EVENTOS** é um ponto muito crítico: cadastro, confecção, emissão são áreas que demandam muita atenção. Falhas em algum processo de alguma dessas áreas podem comprometer o prazo de entrega destes certificados, deteriorando assim a relação entre Organização e participantes, bem como comprometendo a imagem do evento perante seu público futuro. Sendo assim, criar tecnologias que promovam agilidade, segurança e transparência para tal processo seria de grande valia para o setor de eventos.

## ENTENDENDO AGREGADORES REGRAS

- Modelo de invariantes verdadeiros em limites de consistência
  - (consistência transacional).
- Modele Agregadores pequenos
- Referencie outros agregadores por Identidade
