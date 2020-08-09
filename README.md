# ToKoBeDia Website Prototype Project
ToKoBeDia Project merupakan sebuah project kuliah yang diberikan kepada saya. Saya dan tim membuat sebuah prototype proses dari sebuah website e-commerce, mulai dari adanya akun user, product yang dijual, hingga proses pembelian. ToKoBeDia Project merupakapn sebuah project website yang berfokus pada Back-End, sehingga kami tidak berfokus pada tampilan website, melainkan proses kerja dari sebua e-commerce pada umumnya. ToKoBeDia Project dibuat dengan bahasa C#, ASP.NET, serta Databsase yang kami buat di aplikasi Visual Studio 2015 Berikut adalah detail dari fitur e-commerse ToKoBeDia yang kami buat  

<h3> Register & Login </h3>    
<p>
  User (yang menggunakan prototype) dapat membuat/registrasi akun. Ketika sudah membuat akun, maka data yang dimasukkan akan 
  otomatis tersimpan dalam database user. Ketika ingin mengakses prototype, maka user    dapat melakukan login dengan memasukkan 
  data sesuai dengan data yang telah dimasukkan saat registrasi. User akan dibagi menjadi dua kategori, yaitu member dan admin.
</p>
<br/>

<h3>Edit Profile    </h3>  
<p>
  User dapat melakukan pembaharuan terhadap data diri mereka, seperti nama, gender, dll. Selain data diri, user juga dapat merubah 
  password yang sudah mereka buat saat registrasi. Jika user berhasil melakukan pembaharuan, maka data yang terdapat dalam 
  database juga akan terganti secara otamatis. Ketika user sudah mengganti password, maka user harus menggunakan password terbaru 
  ketika ingin login kembali 
</p>
<br/>

<h3> View Profile </h3>     
<p>
  User dapat melihat profile/data diri mereka. Untuk member, mereka dapat melihat data diri masing masing. Sedangkan, untuk admin, 
  dapat melihat daftar semua member yang terdaftar dalam database  
</p>
<br/>

<h3>View Product   </h3>   
<p>
  User dapat melihat semua produk yang terdapat di ToKoBeDia. Kami akan menampilkan semua produk, beserta detail penjelasannya,  
  yang sudah tercantum dalam database kami. Member hanya dapat melihat produk, sementara admin dapat mengatur produk ToKoBeDia
</p>
<br/>

<h3>Product Management    </h3>   
<p>
  Product Management dapat dilakukan oleh user yang telah menjadi admin. Berikut adalah proses yang dapat dilakukan oleh admin 
  kepada produk:
  <ul>
    <li>
      Insert Product           
      <p>
        Admin dapat memasukkan macam macam produk ke dalam prototype ini. Ketika berhasil 
        dimasukkan, maka data produk akan secara otomatis masuk ke dalam Database Product   
      </p>
    </li>
    <li>
      Delete Product          
      <p>
        Jika ingin 
        menghapus produk dari daftar produk yang sudah ada, maka admin dapat menghapus produk yang diinginkan. Ketika berhasil 
        dihapus, maka secara otomatis data produk tersebut akan terhapus dari database
      </p>
    </li>
    <li>Update Product           
      <p>
        Sebuah produk juga dapat diperbaharui, seperti mengganti nama, jumlah, dan lainnya. Admin juga dapat melakukan pembaharuan 
        terhadap setiap produk yang sudah terdapat dalam database.  Data produk pada database juga akan otomatis             
        berubah jika proses pembaharuan berhasil 
      </p>
    </li>
  </ul> 
</p>
<br/>

<h3>View Product Type  </h3>    
<p> 
  Product Type (tipe produk) merupakan sebuah penggolongan beberapa produk yang memiliki kesamaan jenis. Misalkan, terdapat produk 
  mangga, jeruk, dan apel. Kami membuat tipe produk "buah-buahan" untuk menggolongkan ketiga produk tersebut.     hanya admin yang 
  dapat melihat semua tipe produk yang terdapat di ToKoBeDia. Kami akan menampilkan semua tipe produk, beserta detail 
  penjelasannya,  yang sudah tercantum dalam database kami 
</p>
<br/>

<h3>Product Type Management    </h3>        
<p>
  Sama seperti Product Management, admin dapat melakukan beberapa pengaturan terhadap tipe product. . Berikut adalah pengaturan 
  yang dapat dilakukan oleh admin kepada tipe produk       
  
  <ul>
    <li>
      Insert Product Type          
      <p>
        Admin dapat memasukkan macam macam tipe 
        produk ke dalam prototype ini. Ketika berhasil dimasukkan, maka data tipe produk akan secara otomatis masuk ke dalam 
        Database Product Type    
      </p>
    </li>
    <li>
      Delete Product Type          
      <p>
        Jika ingin menghapus produk dari daftar tipe produk yang sudah ada, maka admin dapat 
        menghapus tipe produk yang diinginkan. Ketika berhasil dihapus, maka tipeproduk akan secara otomatis terhapus dari 
        Database Product Type   
      </p>
    </li>
    <li>
      Update Product Type           
      <p>
        Admin juga dapat melakukan pembaharuan terhadap setiap tipe produk yang sudah 
        terdapat dalam database.  Data tipe produk pada database juga akan otomatis berubah jika proses pembaharuan 
        berhasil  
      </p>
    </li> 
  </ul>
</p>
<br/>

<h3>View Payment Type     </h3>  
<p>
  Seperti e-commerce pada umumnya, Payment Type (metode pembayaran) merupakan sebuah kumpulan dari cara pembayaran, seperti 
  melalui m-banking, Cash on Delivery (Bayar di tempat), dan masih banyak lagi. Member dan Admin dapat memilih metode 
  pembayaran ketika ingin membeli produk. Tetapi, admin yang melakukan pengaturan terhadap metode pembayaran  yang terdapat di T
  ToKoBeDia.
 </p>
<br/>

<h3>Payment Type Management    </h3>   
<p>
  Admin dapat melakukan beberapa pengaturan terhadap metode pembayaran . Berikut adalah pengaturan yang dapat dilakukan oleh 
  admin kepada metode pembayaran    
  <ul>
    <li>Insert Payment Type          
      <p>
        Admin dapat memasukkan macam macam produk ke dalam 
        prototype ini. Ketika berhasil dimasukkan, maka data produk akan secara otomatis masuk ke dalam Database Payment Type   
      </p>
    </li>
    <li>Delete Payment Type          
      <p>
        Jika ingin menghapus metode pembayaran dari daftar produk yang sudah ada, maka admin dapat 
        menghapus produk yang diinginkan. Ketika berhasil dihapus, maka produk akan secara otomatis terhapus dari Database 
        Payment
      </p>
    </li>
    <li>Update Payment Type           
      <p>
        Admin juga dapat melakukan pembaharuan terhadap setiap metode pembayaran yang sudah tedaftar dalam database.  
        Data metode pembayaran pada database juga akan otomatis berubah jika proses pembaharuan berhasil   
      </p>
    </li>
  </ul>
</p>
<br/>

<h3>Membeli barang     </h3>  
<p>
  Member dapat memilih produk yang ingin dibeli, dengan memasukkan produk tersebut ke dalam sebuah keranjang (cart). Jika proses 
  pengambilan barang ke dalam keranjang sudah selesai, maka member dapat melanjutkan proses transaksi berikutnya
</p>
<br/>

<h3>Checkout Product    </h3>   
<p>
  Setelah memasukkan produk ke dalam keranjang, member dapat melakukan checkout (pembelian).  Berikut proses checkout yang kami 
  buat  
  <ul>
    <li>Ketika Checkout, kami akan menampilkan semua produk yang telah dimasukkan ke dalam keranjang     </li>
    <li>Setelah itu, member dapat memilih metode pembayaran yang diinginkan  </li>
    <li>Jika sudah memilih metode pembayaran, maka member dapat menekan tombol untuk submit, dan barang pun berhasil terbeli</li>
  </ul>
  Ketika checkout sebuah barang berhasil dilakukan, maka jumlah produk yang sudah terdaftar dalam database akan berkurang sesuai 
  dengan jumlah barang yang dibeli oleh member.
</p>
<br/>

<h3>Checkout History     </h3>   
<p>
  Kami juga mencatat semua proses checkout yang pernah dilakukan oleh member. Member juga dapat melihat semua checkout yang 
  pernah mereka lakukan.
</p>  
<br/>
