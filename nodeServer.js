var http = require('http');

http.createServer(function (req, res) {
    res.writeHead(200, {'Content-Type': 'text/html'});

    var ts = Date.now();

    var currentDate = new Date(ts);
    var currentHour = currentDate.getHours().toString();

    res.end(currentHour);
}).listen(8000);