pipeline {
    // 声明在任何可用的代理上执行
    agent any

    stages {
        // 阶段1: 从GitHub检出代码
        stage('Checkout') {
            steps {
                // 这里的代码检出通常是自动的，但为了明确性可以显式声明
                checkout scm
            }
        }

        // 阶段2: 编译和打包
        stage('Build') {
            steps {
                // 你的构建命令。例如：
                echo '开始编译代码...'
                // sh 'mvn clean package'  // 如果是Java Maven项目
                // sh 'npm run build'      // 如果是Node.js项目
            }
        }

        // 阶段3: 运行自动化测试
        stage('Test') {
            steps {
                echo '正在运行单元测试...'
                // sh 'mvn test'           // Java Maven测试
                // sh 'npm test'           // Node.js测试
            }
            post {
                always {
                    // 即使测试失败，也收集并发布测试报告
                    // junit 'target/surefire-reports/*.xml' 
                }
            }
        }

        // 阶段4: 部署到目标环境
        stage('Deploy') {
            steps {
                echo '开始部署应用...'
                // 你的部署命令。例如：
                // sh 'docker build -t my-app .'   // 构建Docker镜像
                // sh 'docker push my-app'          // 推送镜像到仓库
                // sh 'kubectl apply -f deployment.yaml' // 部署到Kubernetes
            }
        }
    }

    // 流水线执行完成后的收尾工作
    post {
        // 无论成功或失败，都会发送通知
        always {
            echo '流水线执行完毕。'
        }
        // 仅在构建成功时执行
        success {
            echo '流水线成功！'
        }
        // 仅在构建失败时执行
        failure {
            echo '流水线失败，请检查日志。'
        }
    }
}
