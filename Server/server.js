
const express = require('express');
const app = express();


// Routes
app.get("/", async (req, res) => {
    var ts = Date.now();

    var currentDate = new Date(ts);
    var currentHour = currentDate.getHours().toString();

    res.send(currentHour);
});

// Start server listening
const port = 8000;
app.listen(port, () => {
    console.log("Server listening on " + port);
});
