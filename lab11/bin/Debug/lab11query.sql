CREATE TABLE Visitors (
    ID INTEGER PRIMARY KEY,
    Name TEXT,
    ID_Trainer INTEGER,
    FOREIGN KEY (ID_Trainer) REFERENCES Coaches(ID)
);

CREATE TABLE Coaches (
    ID INTEGER PRIMARY KEY,
    Name TEXT
);

INSERT INTO Coaches (Name) VALUES ('Coach1');
INSERT INTO Coaches (Name) VALUES ('Coach2');

INSERT INTO Visitors (Name, ID_Trainer) VALUES ('Visitor1', 1);
INSERT INTO Visitors (Name, ID_Trainer) VALUES ('Visitor2', 1);
INSERT INTO Visitors (Name, ID_Trainer) VALUES ('Visitor3', 2);

SELECT * FROM Coaches;
SELECT * FROM Visitors;