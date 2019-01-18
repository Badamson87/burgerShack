-- Create Table Customer(
--   id int NOT NULL AUTO_INCREMENT,
--   name VARCHAR(255) NOT NULL,   
--   PRIMARY KEY(id)
-- );

CREATE TABLE customerFavorite(
  id int NOT NULL AUTO_INCREMENT,
 customerId int NOT NULL,
 burgerId int NOT NULL,

 PRIMARY KEY (id),
 INDEX ( customerId, burgerId),

 FOREIGN KEY (customerID)
  REFERENCES Customer(id)
    ON DELETE CASCADE,

    FOREIGN KEY (burgerId)
      REFERENCES Burger(id)
        ON DELETE CASCADE
);



