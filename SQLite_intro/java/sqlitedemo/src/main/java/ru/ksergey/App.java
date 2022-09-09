package ru.ksergey;

import java.sql.*;
import java.util.Random;

//import java.util.Random;
public final class App {
    public static void main(String[] args) throws SQLException, ClassNotFoundException {
        Class.forName("org.sqlite.JDBC");
        Connection connection = DriverManager.getConnection("jdbc:sqlite:clients.db");
        Statement statement = connection.createStatement();
        String sql = "";
        Random random = new Random();

        // sql = "DROP TABLE clients ";
        // statement.executeUpdate(sql);
        sql = "CREATE TABLE clients ( " +
                "  id INTEGER, " +
                "  full_name TEXT, " +
                "  date_birth TEXT, " +
                "  status INTEGER " +
                ")";
        statement.executeUpdate(sql);

        for (int i = 1; i < 10; i++) {
            sql = String.format("INSERT INTO clients" +
                    "(id, full_name, date_birth, status)" +
                    "VALUES" +
                    "(%d, 'ФИО_%d','%d-%d-%d',%d);",
                    i, i,
                    random.nextInt(1990, 2023),
                    random.nextInt(1, 12),
                    random.nextInt(1, 28),
                    random.nextInt(100, 999));
            statement.executeUpdate(sql);
        }

        sql = "SELECT * FROM clients";

        ResultSet result = connection
                .prepareStatement(sql)
                .executeQuery();
        while (result.next()) {
            System.out.println(
                    String.format(
                            "%s %s %s %s",
                            result.getObject(1),
                            result.getObject(2),
                            result.getObject(3),
                            result.getObject(4)));
        }

        // res = c.prepareStatement(
        // "select count(*) from clients")
        // .executeQuery();
        // System.out.println(res.getObject(1));
    }
}
