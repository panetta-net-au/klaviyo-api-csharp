#!/bin/bash

kiota generate --openapi https://raw.githubusercontent.com/klaviyo/openapi/main/openapi/stable.json -l CSharp -o KlaviyoApi
