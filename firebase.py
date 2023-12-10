import firebase_admin
from firebase_admin import credentials
from firebase_admin import firestore

cred = credentials.Certificate("C:/Users/vkobr/OneDrive/Робочий стіл/SBDZ/lab12/petshop-1840a-firebase-adminsdk-h6xr0-4389421df2.json")
firebase_admin.initialize_app(cred)

def add_data(collection_path, data):
    collection_ref = firestore.client().collection(collection_path)
    collection_ref.add(data)
    print(f'Data successfully added to the collection {collection_path}')

# Add data for the "worker" table
workers_data = [
    {'Initial': 'John', 'position': 'Manager', 'fk_goods': 4, 'fk_checks': 1},
    {'Initial': 'Alice', 'position': 'Clerk', 'fk_goods': 3, 'fk_checks': 3},
    {'Initial': 'Bob', 'position': 'Technician', 'fk_goods': 5, 'fk_checks': 4},
    {'Initial': 'Eva', 'position': 'Supervisor', 'fk_goods': 2, 'fk_checks': 2},
    {'Initial': 'Mike', 'position': 'Assistant', 'fk_goods': 1, 'fk_checks': 5},
]

for data in workers_data:
    add_data("worker", data)

# Add data for the "checks" table
checks_data = [
    {'fSum': 100.50, 'fdate': '2023-09-26', 'fk_goods': 5, 'fk_worker': 1},
    {'fSum': 75.25, 'fdate': '2023-09-25', 'fk_goods': 1, 'fk_worker': 2},
    {'fSum': 120.75, 'fdate': '2023-09-24', 'fk_goods': 4, 'fk_worker': 3},
    {'fSum': 50.00, 'fdate': '2023-09-23', 'fk_goods': 2, 'fk_worker': 5},
    {'fSum': 200.00, 'fdate': '2023-09-22', 'fk_goods': 3, 'fk_worker': 4},
]

for data in checks_data:
    add_data("checks", data)

# Add data for the "distributor" table
distributor_data = [
    {'fName': 'Distributor A', 'phone': 879395, 'fk_goods': 5},
    {'fName': 'Distributor B', 'phone': 78235, 'fk_goods': 2},
    {'fName': 'Distributor C', 'phone': 848351, 'fk_goods': 3},
    {'fName': 'Distributor D', 'phone': 615691, 'fk_goods': 4},
    {'fName': 'Distributor E', 'phone': 55608, 'fk_goods': 1},
]

for data in distributor_data:
    add_data("distributor", data)

# Add data for the "goods" table
goods_data = [
    {'fName': 'Product 1', 'fCount': 50, 'Price': 20, 'fk_checks': 5, 'fk_distributor': 3},
    {'fName': 'Product 2', 'fCount': 50, 'Price': 10, 'fk_checks': 1, 'fk_distributor': 1},
    {'fName': 'Product 3', 'fCount': 50, 'Price': 15, 'fk_checks': 2, 'fk_distributor': 3},
    {'fName': 'Product 4', 'fCount': 100, 'Price': 25, 'fk_checks': 3, 'fk_distributor': 4},
    {'fName': 'Product 5', 'fCount': 100, 'Price': 30, 'fk_checks': 4, 'fk_distributor': 2},
]

for data in goods_data:
    add_data("goods", data)