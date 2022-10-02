function draw() {
  var canvas = document.getElementById('canvas');
  var ctx = canvas.getContext('2d');

  for (let i = 0; i < 256; i++) {
    for (let j = 0; j < 256; j++) {
      ctx.fillStyle = `rgb(${256 - i}, ${j}, ${i - j})`;
      ctx.fillRect(i, j, 1, 1);
    }
  }
}
draw();