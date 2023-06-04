/*
 * ER/Studio Data Architect SQL Code Generation
 * Project :      Diagrama ER Casa del Arte.DM1
 *
 * Date Created : Sunday, June 04, 2023 09:25:23
 * Target DBMS : Microsoft SQL Server 2017
 */

/* 
 * TABLE: Categoría 
 */

/*
CREATE DATABASE DBLaCasaDelArte
go

USE DBLaCasaDelArte
go
*/

CREATE TABLE Categoría(
    id_categoria       int              IDENTITY(1,1),
    nombreCatg         nvarchar(50)     NOT NULL,
    descripcionCatg    nvarchar(100)    NULL,
    estado             bit              DEFAULT 1 NOT NULL,
    CONSTRAINT PK4 PRIMARY KEY CLUSTERED (id_categoria)
)
go



IF OBJECT_ID('Categoría') IS NOT NULL
    PRINT '<<< CREATED TABLE Categoría >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Categoría >>>'
go

/* 
 * TABLE: Empresa 
 */

CREATE TABLE Empresa(
    id_empresa       int              IDENTITY(1,1),
    nombreEmpresa    nvarchar(50)     NOT NULL,
    ruc              nchar(11)        NOT NULL,
    eslogan          nvarchar(30)     NULL,
    direccion        nvarchar(100)    NULL,
    telefono         nchar(15)        NOT NULL,
    gmail            nvarchar(100)    NULL,
    logo             image            NULL,
    estado           bit              DEFAULT 1 NOT NULL,
    CONSTRAINT PK20 PRIMARY KEY CLUSTERED (id_empresa)
)
go



IF OBJECT_ID('Empresa') IS NOT NULL
    PRINT '<<< CREATED TABLE Empresa >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Empresa >>>'
go

/* 
 * TABLE: Marca 
 */

CREATE TABLE Marca(
    id_marca            int              IDENTITY(1,1),
    nombreMarca         nvarchar(50)     NOT NULL,
    descripcionMarca    nvarchar(100)    NULL,
    estado              bit              DEFAULT 1 NOT NULL,
    CONSTRAINT PK21 PRIMARY KEY CLUSTERED (id_marca)
)
go



IF OBJECT_ID('Marca') IS NOT NULL
    PRINT '<<< CREATED TABLE Marca >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Marca >>>'
go

/* 
 * TABLE: Movimiento 
 */

CREATE TABLE Movimiento(
    id_movimiento       int              IDENTITY(1,1),
    id_producto         nchar(15)        NOT NULL,
    usuario_id          int              NOT NULL,
    tipo_movimiento     bit              NOT NULL,
    fecha_movimiento    datetime         NOT NULL,
    cantidadProd        int              NOT NULL,
    descripcionMov      nvarchar(100)    NULL,
    CONSTRAINT PK22 PRIMARY KEY CLUSTERED (id_movimiento)
)
go



IF OBJECT_ID('Movimiento') IS NOT NULL
    PRINT '<<< CREATED TABLE Movimiento >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Movimiento >>>'
go

/* 
 * TABLE: Permiso 
 */

CREATE TABLE Permiso(
    id_permiso     int              IDENTITY(1,1),
    permiso        nvarchar(50)     NOT NULL,
    descripcion    nvarchar(100)    NULL,
    estado         bit              DEFAULT 1 NOT NULL,
    CONSTRAINT PK18 PRIMARY KEY CLUSTERED (id_permiso)
)
go



IF OBJECT_ID('Permiso') IS NOT NULL
    PRINT '<<< CREATED TABLE Permiso >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Permiso >>>'
go

/* 
 * TABLE: Producto 
 */

CREATE TABLE Producto(
    id_producto            nchar(15)        NOT NULL,
    id_categoria           int              NOT NULL,
    id_marca               int              NOT NULL,
    nombreProd             nvarchar(50)     NOT NULL,
    precio_unitario        float            NOT NULL,
    descripcionProd        nvarchar(100)    NULL,
    inventario_inicial     int              NOT NULL,
    cantidad_disponible    int              NOT NULL,
    estado                 bit              DEFAULT 1 NOT NULL,
    CONSTRAINT PK1 PRIMARY KEY CLUSTERED (id_producto)
)
go



IF OBJECT_ID('Producto') IS NOT NULL
    PRINT '<<< CREATED TABLE Producto >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Producto >>>'
go

/* 
 * TABLE: Rol 
 */

CREATE TABLE Rol(
    ID_Rol            int              IDENTITY(1,1),
    nombreRol         nvarchar(50)     NOT NULL,
    descripcionRol    nvarchar(100)    NULL,
    estado            bit              DEFAULT 1 NOT NULL,
    CONSTRAINT PK3 PRIMARY KEY CLUSTERED (ID_Rol)
)
go



IF OBJECT_ID('Rol') IS NOT NULL
    PRINT '<<< CREATED TABLE Rol >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Rol >>>'
go

/* 
 * TABLE: RolPermiso 
 */

CREATE TABLE RolPermiso(
    id_rol_permiso    int    IDENTITY(1,1),
    id_permiso        int    NOT NULL,
    ID_Rol            int    NOT NULL,
    CONSTRAINT PK19 PRIMARY KEY CLUSTERED (id_rol_permiso)
)
go



IF OBJECT_ID('RolPermiso') IS NOT NULL
    PRINT '<<< CREATED TABLE RolPermiso >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE RolPermiso >>>'
go

/* 
 * TABLE: Usuario 
 */

CREATE TABLE Usuario(
    usuario_id          int             IDENTITY(1,1),
    ID_Rol              int             NOT NULL,
    primer_nombre       nvarchar(50)    NOT NULL,
    segundo_nombre      nvarchar(50)    NULL,
    primer_apellido     nvarchar(50)    NOT NULL,
    segundo_apellido    nvarchar(50)    NULL,
    nombre_usuario      nvarchar(50)    NOT NULL,
    telefono            nchar(15)       NOT NULL,
    fecha_nac           datetime        NOT NULL,
    cedula              nchar(16)       NOT NULL,
    contraseña          nvarchar(50)    NOT NULL,
    estado              bit             DEFAULT 1 NOT NULL,
    CONSTRAINT PK2 PRIMARY KEY CLUSTERED (usuario_id)
)
go



IF OBJECT_ID('Usuario') IS NOT NULL
    PRINT '<<< CREATED TABLE Usuario >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Usuario >>>'
go

/* 
 * INDEX: Ref242 
 */

CREATE INDEX Ref242 ON Movimiento(usuario_id)
go
IF EXISTS (SELECT * FROM sys.indexes WHERE object_id=OBJECT_ID('Movimiento') AND name='Ref242')
    PRINT '<<< CREATED INDEX Movimiento.Ref242 >>>'
ELSE
    PRINT '<<< FAILED CREATING INDEX Movimiento.Ref242 >>>'
go

/* 
 * INDEX: Ref147 
 */

CREATE INDEX Ref147 ON Movimiento(id_producto)
go
IF EXISTS (SELECT * FROM sys.indexes WHERE object_id=OBJECT_ID('Movimiento') AND name='Ref147')
    PRINT '<<< CREATED INDEX Movimiento.Ref147 >>>'
ELSE
    PRINT '<<< FAILED CREATING INDEX Movimiento.Ref147 >>>'
go

/* 
 * INDEX: Ref44 
 */

CREATE INDEX Ref44 ON Producto(id_categoria)
go
IF EXISTS (SELECT * FROM sys.indexes WHERE object_id=OBJECT_ID('Producto') AND name='Ref44')
    PRINT '<<< CREATED INDEX Producto.Ref44 >>>'
ELSE
    PRINT '<<< FAILED CREATING INDEX Producto.Ref44 >>>'
go

/* 
 * INDEX: Ref2137 
 */

CREATE INDEX Ref2137 ON Producto(id_marca)
go
IF EXISTS (SELECT * FROM sys.indexes WHERE object_id=OBJECT_ID('Producto') AND name='Ref2137')
    PRINT '<<< CREATED INDEX Producto.Ref2137 >>>'
ELSE
    PRINT '<<< FAILED CREATING INDEX Producto.Ref2137 >>>'
go

/* 
 * INDEX: Ref1835 
 */

CREATE INDEX Ref1835 ON RolPermiso(id_permiso)
go
IF EXISTS (SELECT * FROM sys.indexes WHERE object_id=OBJECT_ID('RolPermiso') AND name='Ref1835')
    PRINT '<<< CREATED INDEX RolPermiso.Ref1835 >>>'
ELSE
    PRINT '<<< FAILED CREATING INDEX RolPermiso.Ref1835 >>>'
go

/* 
 * INDEX: Ref336 
 */

CREATE INDEX Ref336 ON RolPermiso(ID_Rol)
go
IF EXISTS (SELECT * FROM sys.indexes WHERE object_id=OBJECT_ID('RolPermiso') AND name='Ref336')
    PRINT '<<< CREATED INDEX RolPermiso.Ref336 >>>'
ELSE
    PRINT '<<< FAILED CREATING INDEX RolPermiso.Ref336 >>>'
go

/* 
 * INDEX: Ref334 
 */

CREATE INDEX Ref334 ON Usuario(ID_Rol)
go
IF EXISTS (SELECT * FROM sys.indexes WHERE object_id=OBJECT_ID('Usuario') AND name='Ref334')
    PRINT '<<< CREATED INDEX Usuario.Ref334 >>>'
ELSE
    PRINT '<<< FAILED CREATING INDEX Usuario.Ref334 >>>'
go

/* 
 * TABLE: Movimiento 
 */

ALTER TABLE Movimiento ADD CONSTRAINT RefUsuario42 
    FOREIGN KEY (usuario_id)
    REFERENCES Usuario(usuario_id)
go

ALTER TABLE Movimiento ADD CONSTRAINT RefProducto47 
    FOREIGN KEY (id_producto)
    REFERENCES Producto(id_producto)
go


/* 
 * TABLE: Producto 
 */

ALTER TABLE Producto ADD CONSTRAINT RefCategoría4 
    FOREIGN KEY (id_categoria)
    REFERENCES Categoría(id_categoria)
go

ALTER TABLE Producto ADD CONSTRAINT RefMarca37 
    FOREIGN KEY (id_marca)
    REFERENCES Marca(id_marca)
go


/* 
 * TABLE: RolPermiso 
 */

ALTER TABLE RolPermiso ADD CONSTRAINT RefPermiso35 
    FOREIGN KEY (id_permiso)
    REFERENCES Permiso(id_permiso)
go

ALTER TABLE RolPermiso ADD CONSTRAINT RefRol36 
    FOREIGN KEY (ID_Rol)
    REFERENCES Rol(ID_Rol)
go


/* 
 * TABLE: Usuario 
 */

ALTER TABLE Usuario ADD CONSTRAINT RefRol34 
    FOREIGN KEY (ID_Rol)
    REFERENCES Rol(ID_Rol)
go


