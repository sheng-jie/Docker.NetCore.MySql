# Dockerize And Deploy ASP.NET Core 2.0 + Mysql + Nginx With Docker-Compose
This is an example web application to show how to use ASP.Net Core with MySQL database and use Nginx as reverse proxy, and deploy using Docker-Compose.

# How to use?
1. `git clone https://github.com/yanshengjie/Docker.NetCore.MySql.git`
2. `cd Docker.NetCore.MySql`
3. `docker-compose up -d`
4. `curl -i http://localhost:9090/api/products`

For detail reference:[.NET Core+MySql+Nginx 容器化部署](https://www.jianshu.com/p/2a755277a1e6)

# Reference
1. [mysql -Docker Documentation](https://docs.docker.com/samples/library/mysql/)
2. [Hello Docker](https://www.jianshu.com/p/bc9ea9eaafe0)
3. [.NET Core容器化@Docker](https://www.jianshu.com/p/23465dc86d3e)
4. [.NET Core容器化之多容器应用部署@Docker-Compose](https://www.jianshu.com/p/1cf84a27de0f)
