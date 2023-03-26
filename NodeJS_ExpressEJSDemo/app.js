const express = require('express')
const app = express();
app.set('view engine', 'ejs');
app.set('views', './views');

const PORT = ####;

function getData() {
  let data = [];

  let count = Math.floor(Math.random() * 10 + 2);
  for (let i = 0; i < count; i++) {
    data.push(Math.floor(Math.random() * 10));
  }
  return data;
}

app.get('/', function (req, res) {
  res.render('index.ejs', { title: 'Главная', data: getData() });
});

app.get('/demo', function (req, res) {
  res.render('demo.ejs', { title: 'demo' });
});

app.get('/error', function (req, res) {
  res.render('error.ejs', { title: 'error' });
});
app.listen(PORT);