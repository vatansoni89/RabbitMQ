# Setup

* Install erlang
* install rabbitMQ
* Enable rabbit mq management: 
    1. open rabbit mq command prompt
    2. `execute command` rabbitmq-plugins enable rabbitmq_management
    3. navigate to http://localhost:15672

# Basic command
  * Stop: rabbitmqctl stop_app
  * Start: rabbitmqctl start_app
  * Reset: rabbitmqctl reset `(Be careful)`
  * Add user: rabbitmqctl add_user test test
  * set role: rabbitmqctl set_user_tags test administrator
  * set read write permission: rabbitmqctl set_permissions -p / test ".*" ".*" ".*"

# 