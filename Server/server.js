
const express = require('express');
const app = express();

const date = require('date-and-time');

// Routes
app.get("/", async (req, res) => {
    const now = new Date();
    var currentHour = date.format(now, 'hh:mm A [GMT]Z'); 

    res.send(currentHour);
});

// Start server listening
const port = 8000;
app.listen(port, () => {
    console.log("Server listening on " + port);
});
