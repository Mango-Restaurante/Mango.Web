

<h1>🍈 Mango.Web</h1>

<p>Este proyecto forma parte de la plataforma Mango y ofrece una interfaz web desarrollada en .NET 8.0 para la gestión de cupones y notificaciones. Utiliza **Toastr** para notificaciones visuales y cuenta con un servicio de cupones, el <code>CouponService</code>, que permite interactuar con el controlador de cupones.</p>

<h2>✨ Funcionalidades</h2>
<ul>
    <li>📢 <strong>Notificaciones Toastr</strong>: Notificaciones visuales para mejorar la experiencia de usuario en el manejo de cupones.</li>
    <li>🔄 <strong>Controlador de Cupones</strong>: <code>CouponController</code> para la gestión de cupones en el sistema.</li>
    <li>💼 <strong>CouponService</strong>: Servicio que maneja la lógica de cupones a través de una interfaz dedicada.</li>
</ul>

<h2>📂 Estructura del Proyecto</h2>
<ul>
    <li><strong>Controllers</strong>: Controladores de la API, incluyendo <code>CouponController</code> para las operaciones de cupones.</li>
    <li><strong>Models</strong>: Modelos de datos utilizados para la implementación de cupones.</li>
    <li><strong>Properties</strong>: Configuraciones básicas de la aplicación web.</li>
    <li><strong>Service</strong>: Contiene el servicio <code>CouponService</code> con sus métodos y lógica de negocio.</li>
    <li><strong>Utility</strong>: Interfaces y utilidades para el <code>CouponService</code>.</li>
    <li><strong>Views</strong>: Vistas de la aplicación que interactúan con los cupones y muestran notificaciones Toastr.</li>
    <li><strong>wwwroot</strong>: Recursos estáticos, como archivos JavaScript y CSS para Toastr.</li>
</ul>

<h2>⚙️ Configuración</h2>

<h3>🔑 Archivos de Configuración</h3>
<p>Los archivos <code>appsettings.json</code> y <code>appsettings.Development.json</code> contienen la configuración de entorno y datos necesarios para el funcionamiento del proyecto.</p>

<h2>📋 Requisitos Previos</h2>
<ul>
    <li><strong>.NET SDK 8.0</strong> o superior.</li>
    <li><strong>SQL Server</strong> o un sistema de base de datos compatible (si es necesario para almacenar los datos de cupones).</li>
</ul>

<h2>🚀 Instalación</h2>
<ol>
    <li>Clonar el repositorio:
        <pre><code>git clone https://github.com/tu-usuario/Mango.Web.git</code></pre>
    </li>
    <li>Restaurar los paquetes de NuGet:
        <pre><code>dotnet restore</code></pre>
    </li>
    <li>Configurar la base de datos (si es aplicable) y realizar las migraciones necesarias:
        <pre><code>dotnet ef database update</code></pre>
    </li>
    <li>Ejecutar el proyecto:
        <pre><code>dotnet run</code></pre>
    </li>
</ol>

<h2>🌐 Principales Endpoints y Vistas</h2>
<ul>
    <li><strong>CouponController</strong>: Controlador principal para la gestión de cupones.</li>
    <li><strong>Notificaciones Toastr</strong>: Notificaciones automáticas en la interfaz de usuario.</li>
</ul>

<h2>⏳ Pendiente</h2>
<p>⚠️ Se está trabajando en el método <code>SendAsync</code> del servicio <code>Service</code> para mejorar las comunicaciones asincrónicas.</p>

<h2>💬 Contacto</h2>
<p>Este proyecto forma parte de la plataforma Mango. Si tienes alguna pregunta o deseas contribuir, por favor, crea un issue o realiza un pull request.</p>

</body>
</html>
