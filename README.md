_Repositório apenas para estudo_

# Curso: Construindo aplicações em Contextos Delimitados

Neste curso vamos aprender mais sobre a criação de aplicações em contextos delimitados.

Instrutor:

- [Yan de Lima Justino](https://balta.io/contribuidores/yan-justino)

Referências:

- https://balta.io/cursos/construindo-aplicacoes-em-contextos-delimitados

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
