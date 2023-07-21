# ProblemSolvingTest
Merupakan program problem solving menggunakan C#

# Balanced Bracket
Kompleksitas kodingan ini adalah O(n), di mana n adalah panjang dari input string. Algoritma ini menggunakan satu perulangan untuk memproses setiap karakter dalam string. Selama perulangan, algoritma melakukan operasi push dan pop pada stack, yang masing-masing memiliki kompleksitas waktu O(1). Jumlah operasi push dan pop yang dilakukan sejajar dengan panjang input string, sehingga kompleksitas keseluruhan menjadi O(n). Selain itu, algoritma ini menggunakan satu stack untuk menyimpan karakter bracket buka yang belum memiliki pasangan bracket tutup. Ketika karakter bracket tutup ditemukan, algoritma memeriksa apakah bracket buka terakhir pada stack cocok dengan bracket tutup saat ini. Jika ya, bracket buka tersebut dikeluarkan dari stack. Jika tidak, algoritma mengembalikan nilai false karena tanda kurung tidak seimbang.
