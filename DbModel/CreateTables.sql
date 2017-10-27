
CREATE TABLE Usuario (
    Id INT IDENTITY(1,1) NOT NULL,
    Nome VARCHAR(100) NOT NULL,
    Cargo INT NOT NULL,

    CONSTRAINT PKUsuario
        PRIMARY KEY (Id),

    CONSTRAINT CKUsuarioCargo
        CHECK (Cargo BETWEEN 1 AND 5)
)

CREATE TABLE Produto (
    Id INT IDENTITY(1,1) NOT NULL,
    Nome VARCHAR(200) NOT NULL,
    ValorSW DECIMAL(14, 2) NOT NULL,
    ValorHW DECIMAL(14, 2) NOT NULL,
    PercFornecedorSW DECIMAL(14, 4) NOT NULL,
    PercFornecedorHW DECIMAL(14, 4) NOT NULL,

    CONSTRAINT PKProduto
        PRIMARY KEY (Id)
)

CREATE TABLE ComsCargo (
    Id INT IDENTITY(1,1) NOT NULL,
    ProdutoId INT NOT NULL,
    Cargo INT NOT NULL,
    PercComsSW DECIMAL(14, 4) NOT NULL,
    PercComsHW DECIMAL(14, 4) NOT NULL,

    CONSTRAINT PKComsCargo
        PRIMARY KEY (Id),

    CONSTRAINT FKComsCargoProduto
        FOREIGN KEY (ProdutoId)
            REFERENCES Produto(Id),

    CONSTRAINT CKComsCargoCargo
        CHECK (Cargo BETWEEN 1 AND 5),

    CONSTRAINT UKComsCargoProdutoCargo
        UNIQUE (ProdutoId, Cargo)
)

CREATE TABLE Venda (
    Id INT IDENTITY(1,1) NOT NULL,
    UsuarioId INT NOT NULL,
    ProdutoId INT NOT NULL,
    NomeCliente VARCHAR(100) NOT NULL,

    CONSTRAINT PKVenda
        PRIMARY KEY (Id),

    CONSTRAINT FKVendaUsuario
        FOREIGN KEY (UsuarioId)
            REFERENCES Usuario(Id),

    CONSTRAINT FKVendaProduto
        FOREIGN KEY (ProdutoId)
            REFERENCES Produto(Id)
)
