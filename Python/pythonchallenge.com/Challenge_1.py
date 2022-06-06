import string

#  g fmnc wms bgblr rpylqjyrc gr zw fylb. rfyrq ufyr amknsrcpq ypc dmp.
#  bmgle gr gl zw fylb gq glcddgagclr ylb rfyr'q ufw rfgq rcvr gq qm jmle.
#  sqgle qrpgle.kyicrpylq() gq pcamkkclbcb. lmu ynnjw ml rfc spj.

# Decrypted message is i hope you didnt translate it by hand. thats what computers are for.
# doing it in by hand is inefficient and that's why this text is so long.
#  using string.maketrans() is recommended. now apply on the url.
#######################################################
# alphabet = string.ascii_letters
# key = 2

# # Must be a shorter way to do this
# def decryptmsg():
#     code = input("Please enter the code: ")
#     decrypt = ""
#     for i in code:
#         if i in alphabet:
#             position = alphabet.find(i)
#             newPosition = (position + key) % 26
#             newChar = alphabet[newPosition]
#             decrypt += newChar
#         elif i not in alphabet:
#             decrypt += i
#     print(decrypt)
#
# decryptmsg()
#######################################################

alphabet = string.ascii_lowercase
key = "nopqrstuvwxyzabcdefghijklm"

def decrypt():
    print("This move all characters in your message by 2 positions!")
    message = input("Please enter the coded message: ")
    trans = message.maketrans(alphabet, key)
    print(message.translate(trans))

decrypt()