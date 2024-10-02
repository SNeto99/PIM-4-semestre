import express from "express";
import userRoutes from "./userRoutes.js";


const routes = (app) => {

    app.use(express.static("paginas"));

    app.get("/hello", (req, res) => {
        res.status(200).send("Hello World!!!");
    });

    app.use("/users", express.json(), userRoutes);

};

export default routes;