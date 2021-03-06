

============
子服务器绑定
============

接口描述
=========
用于将子服务器ID与一个账户绑定，使该账户对子服务器拥有权限并建立所属关系

请求说明
=========

**HTTP方法：** POST
**请求URL:**  http://www.writebug.site/api/SubServerBind
**URL参数：**

*Header*

+--------------+------------------+
|     参数     |        值        |
+==============+==================+
| Content-Type | application/json |
+--------------+------------------+

*Body*

放置JSON包，其节点详情如下：

+-------------+----------+--------+------------------------------------------+
|    参数     | 是否必选 |  类型  |                   说明                   |
+=============+==========+========+==========================================+
| actoken     | 是       | string | 用户认证的唯一标识，每一次登录即获得一次 |
+-------------+----------+--------+------------------------------------------+
| SubserverId | 是       | Sting  | 子服务器的唯一标识                       |
+-------------+----------+--------+------------------------------------------+



**请求示例：**

.. code-block:: json

	{
			"actoken":" b98774f1-3406-400f-8e51-407abe4d79f0",
			"subserverId":"b98774f1-3406-400f-8e51-407abe4d79f0"
	}

返回说明
========

**返回类型：** JSON

**返回参数：**：


+------------+----------+------+---------------------------+--------------+
|  返回参数  | 是否必选 | 类型 |            值             |     说明     |
+============+==========+======+===========================+==============+
| error_code | string   | 是   | 1000                      | 设备绑定成功 |
+------------+----------+------+---------------------------+--------------+
| Msg        | sting    | 是   | SubServer binding success | 详细信息     |
+------------+----------+------+---------------------------+--------------+	

**返回示例：**

.. code-block:: json

	{
			"error_code":"1000",
			"msg":" SubServer binding success"
	}

错误码说明
==========

+------------+-------------------------------------+----------------------------+
| Error_code |                 msg                 |            说明            |
+============+=====================================+============================+
| 0001       | JSON format error                   | 发送的JSON包格式不符合要求 |
+------------+-------------------------------------+----------------------------+
| fdsf       | Invalid access_Token                | s                          |
+------------+-------------------------------------+----------------------------+
| fs         | This Subserver is owned by user     | fs                         |
+------------+-------------------------------------+----------------------------+
|            | SubServer binding failed            |                            |
+------------+-------------------------------------+----------------------------+
|            | MAC is not available                |                            |
+------------+-------------------------------------+----------------------------+
|            | MAC contains dangerous characters   |                            |
+------------+-------------------------------------+----------------------------+
|            | Token contains dangerous characters |                            |
+------------+-------------------------------------+----------------------------+
		
		
		
		
