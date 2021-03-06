﻿using System;
#pragma warning disable 1591

namespace StealthAPI
{
    public class StartStopEventArgs
    {
        public StartStopEventArgs(bool isStopped)
        {
            IsStopped = isStopped;
        }
        public bool IsStopped { get; private set; }
    }

    public class ItemEventArgs : EventArgs
    {
        public ItemEventArgs(int itemId)
        {
            ItemId = itemId;
        }
        public int ItemId { get; private set; }
    }
    public class ObjectEventArgs : EventArgs
    {
        public ObjectEventArgs(int objectId)
        {
            ObjectId = objectId;
        }
        public int ObjectId { get; private set; }
    }
    public class MessangerErrorEventArgs : EventArgs
    {
        public MessangerErrorEventArgs(string eventMsg)
        {
            Message = eventMsg;
        }
        public string Message { get; private set; }
    }
    public class MessangerTextEventArgs : MessangerErrorEventArgs
    {
        public MessangerTextEventArgs(string senderNickname, string senderId, string chatId, string eventMsg)
            : base(eventMsg)
        {
            SenderNickname = senderNickname;
            SenderId = senderId;
            ChatId = chatId;
        }
        public string SenderNickname { get; private set; }
        public string SenderId { get; private set; }
        public string ChatId { get; private set; }
    }
    public class UpdateObjectStatsEventArgs : EventArgs
    {
        public UpdateObjectStatsEventArgs(int objectId, int currentLife, int maxLife, int currentMana, int maxMana, int currentStamina, int maxStamina)
        {
            ObjectId = objectId;
            CurrentLife = currentLife;
            MaxLife = maxLife;
            CurrentMana = currentMana;
            MaxMana = maxMana;
            CurrentStamina = currentStamina;
            MaxStamina = maxStamina;
        }

        public int ObjectId { get; set; }
        public int CurrentLife { get; set; }
        public int MaxLife { get; set; }
        public int CurrentMana { get; set; }
        public int MaxMana { get; set; }
        public int CurrentStamina { get; set; }
        public int MaxStamina { get; set; }
    }
    public class SetGlobalVarEventArgs : EventArgs
    {
        public SetGlobalVarEventArgs(string name, string value)
        {
            Name = name;
            Value = value;
        }

        public string Name { get; set; }
        public string Value { get; set; }
    }
    public class MessangerIncomingTextEventArgs : MessangerTextEventArgs
    {
        public MessangerIncomingTextEventArgs(MessangerType messangerType, string senderNickname, string senderId, string chatId, string eventMsg, MessangerEventType eventCode)
            : base(senderNickname, senderId, chatId, eventMsg)
        {
            MessangerType = messangerType;
            EventCode = eventCode;
        }
        public MessangerType MessangerType { get; set; }
        public MessangerEventType EventCode { get; set; }
    }
    public class SpeechEventArgs : EventArgs
    {
        public SpeechEventArgs(string text, string senderName, int senderId)
        {
            Text = text;
            SenderName = senderName;
            SenderId = senderId;
        }
        public string Text { get; private set; }
        public string SenderName { get; private set; }
        public int SenderId { get; private set; }
    }
    
    public class MoveRejectionEventArgs : EventArgs
    {
        public MoveRejectionEventArgs(ushort xSource, ushort ySource, byte direction, ushort xDest, ushort yDest)
        {
            XSource = xSource;
            YSource = ySource;
            Direction = direction;
            XDest = xDest;
            YDest = yDest;
        }

        public ushort XSource { get; private set; }
        public ushort YSource { get; private set; }
        public byte Direction { get; private set; }
        public ushort XDest { get; private set; }
        public ushort YDest { get; private set; }
    }
    public class DrawContainerEventArgs : EventArgs
    {
        public DrawContainerEventArgs(int containerId, ushort modelGump)
        {
            ContainerId = containerId;
            ModelGump = modelGump;
        }
        public int ContainerId { get; private set; }
        public ushort ModelGump { get; private set; }
    }
    public class AddItemToContainerEventArgs : ItemEventArgs
    {
        public AddItemToContainerEventArgs(int itemId, int containerId)
            : base(itemId)
        {
            ContainerId = containerId;
        }
        public int ContainerId { get; private set; }
    }
    public class AddMultipleItemsInContainerEventArgs : EventArgs
    {
        public AddMultipleItemsInContainerEventArgs(int containerId)
        {
            ContainerId = containerId;
        }
        public int ContainerId { get; private set; }
    }
    public class RejectMoveItemEventArgs : EventArgs
    {
        public RejectMoveItemEventArgs(RejectMoveItemReasons reason)
        {
            Reason = reason;
        }
        public RejectMoveItemReasons Reason { get; private set; }
    }
    public class MenuEventArgs : EventArgs
    {
        public MenuEventArgs(int dialogId, ushort menuId)
        {
            DialogId = dialogId;
            MenuId = menuId;
        }
        public int DialogId { get; private set; }
        public ushort MenuId { get; private set; }
    }
    public class MapMessageEventArgs : ItemEventArgs
    {
        public MapMessageEventArgs(int itemId, int centerX, int centerY)
            : base(itemId)
        {
            CenterX = centerX;
            CenterY = centerY;
        }
        public int CenterX { get; private set; }
        public int CenterY { get; private set; }
    }
    public class AllowRefuseAttackEventArgs : EventArgs
    {
        public AllowRefuseAttackEventArgs(int targetId, bool isAttackOk)
        {
            TargetId = targetId;
            IsAttackOK = isAttackOk;
        }
        public int TargetId { get; private set; }
        public bool IsAttackOK { get; private set; }
    }
    public class ClilocSpeechEventArgs : EventArgs
    {
        public ClilocSpeechEventArgs(int senderId, string senderName, int clilocId, string text)
        {
            SenderId = senderId;
            SenderName = senderName;
            ClilocId = clilocId;
            Text = text;
        }
        public int SenderId { get; private set; }
        public string SenderName { get; private set; }
        public int ClilocId { get; private set; }
        public string Text { get; private set; }
    }
    public class ClilocSpeechAffixEventArgs : ClilocSpeechEventArgs
    {
        public ClilocSpeechAffixEventArgs(int senderId, string senderName, int clilocId, string affix, string text)
            : base(senderId, senderName, clilocId, text)
        {
            Affix = affix;
        }
        public string Affix { get; private set; }
    }
    public class UnicodeSpeechEventArgs : EventArgs
    {
        public UnicodeSpeechEventArgs(string text, string senderName, int senderId)
        {
            Text = text;
            SenderName = senderName;
            SenderId = senderId;
        }
        public string Text { get; private set; }
        public string SenderName { get; private set; }
        public int SenderId { get; private set; }
    }
    public class Buff_DebuffSystemEventArgs : ObjectEventArgs
    {
        public Buff_DebuffSystemEventArgs(int objectId, ushort attributeId, bool isEnabled)
            : base(objectId)
        {
            AttributeId = attributeId;
            IsEnabled = isEnabled;
        }
        public ushort AttributeId { get; private set; }
        public bool IsEnabled { get; private set; }
    }
    public class CharAnimationEventArgs : ObjectEventArgs
    {
        public CharAnimationEventArgs(int objectId, ushort action)
            : base(objectId)
        {
            Action = action;
        }
        public ushort Action { get; private set; }
    }
    public class ICQIncomingTextEventArgs : EventArgs
    {
        public ICQIncomingTextEventArgs(int uin, string text)
        {
            UIN = uin;
            Text = text;
        }
        public int UIN { get; private set; }
        public string Text { get; private set; }
    }
    public class ICQErrorEventArgs : EventArgs
    {
        public ICQErrorEventArgs(string text)
        {
            Text = text;
        }
        public string Text { get; private set; }
    }
    public class IncomingGumpEventArgs : EventArgs
    {
        public IncomingGumpEventArgs(int serial, uint gumpId, int x, int y)
        {
            Serial = serial;
            GumpId = gumpId;
            X = x;
            Y = y;
        }
        public int Serial { get; private set; }
        public uint GumpId { get; private set; }
        public int X { get; private set; }
        public int Y { get; private set; }
    }
    public class WindowsMessageEventArgs : EventArgs
    {
        public WindowsMessageEventArgs(int lParam)
        {
            LParam = lParam;
        }
        public int LParam { get; private set; }
    }
    public class SoundEventArgs : EventArgs
    {
        public SoundEventArgs(ushort soundId, ushort x, ushort y, int z)
        {
            SoundId = soundId;
            X = x;
            Y = y;
            Z = z;
        }
        public ushort SoundId { get; private set; }
        public ushort X { get; private set; }
        public ushort Y { get; private set; }
        public int Z { get; private set; }
    }
    public class DeathEventArgs : EventArgs
    {
        public DeathEventArgs(bool isDead)
        {
            IsDead = isDead;
        }
        public bool IsDead { get; private set; }
    }
    public class QuestArrowEventArgs : EventArgs
    {
        public QuestArrowEventArgs(ushort x, ushort y, bool isActive)
        {
            X = x;
            Y = y;
            IsActive = isActive;
        }
        public ushort X { get; private set; }
        public ushort Y { get; private set; }
        public bool IsActive { get; private set; }
    }
    public class PartyInviteEventArgs : EventArgs
    {
        public PartyInviteEventArgs(int inviterId)
        {
            InviterId = inviterId;
        }
        public int InviterId { get; private set; }
    }
    public class MapPinEventArgs : EventArgs
    {
        public MapPinEventArgs(int id, byte action,byte pinId,ushort x,ushort y)
        {
            ID = id;
            Action = action;
            PinId = pinId;
            X = x;
            Y = y;
        }

        public int ID { get; private set; }
        public byte Action { get; set; }
        public byte PinId { get; set; }
        public ushort X { get; set; }
        public ushort Y { get; set; }
    }
    public class GumpTextEntryEventArgs : EventArgs
    {
        public GumpTextEntryEventArgs(int gumpTextEntryId, string title,byte inputStyle, int maxValue, string title2)
        {
            GumpTextEntryID = gumpTextEntryId;
            Title = title;
            InputStyle = inputStyle;
            MaxValue = maxValue;
            Title2 = title2;
        }

        public int GumpTextEntryID { get; private set; }
        public string Title { get; set; }
        public byte InputStyle { get; set; }
        public int MaxValue { get; set; }
        public string Title2 { get; set; }
    }
    public class GraphicalEffectEventArgs : EventArgs
    {
        public GraphicalEffectEventArgs(int srcId, ushort srcX,ushort srcY,int srcZ,int dstId, ushort dstX,ushort dstY,int dstZ, byte type, ushort itemId, byte fixedDir)
        {
            SrcId = srcId;
            SrcX = srcX;
            SrcY = srcY;
            SrcZ = srcZ;
            DstId = dstId;
            DstX = dstX;
            DstY = dstY;
            DstZ = dstZ;
            Type = type;
            ItemId = itemId;
            FixedDir = fixedDir;
        }

        public int SrcId { get; private set; }
        public ushort SrcX { get; private set; }
        public ushort SrcY { get; private set; }
        public int SrcZ { get; private set; }
        public int DstId { get; private set; }
        public ushort DstX { get; private set; }
        public ushort DstY { get; private set; }
        public int DstZ { get; private set; }
        public byte Type { get; private set; }
        public ushort ItemId { get; private set; }
        public byte FixedDir { get; private set; }
    }

    public class IRCIncomingTextEventArgs : EventArgs
    {
        public IRCIncomingTextEventArgs(string text)
        {
            Text = text;
        }
        public string Text { get; private set; }
    }

    public class SkypeIncomingTextEventArgs : EventArgs
    {
        public SkypeIncomingTextEventArgs(string senderId, string recieverId, string eventMsg, byte eventCode)
        {
            SenderId = senderId;
            RecieverId = recieverId;
            EventMessage = eventMsg;
            EventCode = eventCode;
        }
        public string SenderId { get; private set; }
        public string RecieverId { get; private set; }
        public string EventMessage { get; private set; }
        public byte EventCode { get; set; }
    }
}
