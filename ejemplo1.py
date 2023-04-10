{
 "cells": [
  {
   "cell_type": "code",
   "execution_count": 4,
   "id": "51069618",
   "metadata": {},
   "outputs": [
    {
     "ename": "ImportError",
     "evalue": "DLL load failed while importing MPI: No se puede encontrar el módulo especificado.",
     "output_type": "error",
     "traceback": [
      "\u001b[1;31m---------------------------------------------------------------------------\u001b[0m",
      "\u001b[1;31mImportError\u001b[0m                               Traceback (most recent call last)",
      "Cell \u001b[1;32mIn[4], line 1\u001b[0m\n\u001b[1;32m----> 1\u001b[0m \u001b[38;5;28;01mfrom\u001b[39;00m \u001b[38;5;21;01mmpi4py\u001b[39;00m \u001b[38;5;28;01mimport\u001b[39;00m MPI\n",
      "\u001b[1;31mImportError\u001b[0m: DLL load failed while importing MPI: No se puede encontrar el módulo especificado."
     ]
    }
   ],
   "source": [
    "from mpi4py import MPI"
   ]
  },
  {
   "cell_type": "code",
   "execution_count": 5,
   "id": "054af024",
   "metadata": {},
   "outputs": [
    {
     "name": "stdout",
     "output_type": "stream",
     "text": [
      "Requirement already satisfied: mpi in c:\\users\\jhon\\appdata\\local\\programs\\python\\python39\\lib\\site-packages (1.0.0)\n",
      "Note: you may need to restart the kernel to use updated packages.\n"
     ]
    }
   ],
   "source": [
    "pip install mpi\n"
   ]
  },
  {
   "cell_type": "code",
   "execution_count": 6,
   "id": "fbfb038c",
   "metadata": {},
   "outputs": [
    {
     "name": "stdout",
     "output_type": "stream",
     "text": [
      "Requirement already satisfied: mpi4py in c:\\users\\jhon\\appdata\\local\\programs\\python\\python39\\lib\\site-packages (3.1.4)\n",
      "Note: you may need to restart the kernel to use updated packages.\n"
     ]
    }
   ],
   "source": [
    "pip install mpi4py"
   ]
  },
  {
   "cell_type": "code",
   "execution_count": null,
   "id": "7379905f",
   "metadata": {},
   "outputs": [],
   "source": []
  },
  {
   "cell_type": "code",
   "execution_count": null,
   "id": "d8a25f4b",
   "metadata": {},
   "outputs": [],
   "source": []
  }
 ],
 "metadata": {
  "kernelspec": {
   "display_name": "Python 3 (ipykernel)",
   "language": "python",
   "name": "python3"
  },
  "language_info": {
   "codemirror_mode": {
    "name": "ipython",
    "version": 3
   },
   "file_extension": ".py",
   "mimetype": "text/x-python",
   "name": "python",
   "nbconvert_exporter": "python",
   "pygments_lexer": "ipython3",
   "version": "3.9.5"
  }
 },
 "nbformat": 4,
 "nbformat_minor": 5
}
