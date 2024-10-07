using System;

namespace Hastalabrisca.Code.GameScenes
{
    public enum OrdenEnumBarajaEspanola
    {
        OROS = 1,
        COPAS,
        ESPADAS,
        BASTOS
    }
    public enum BarajaEspanola
    {
        [EnumValue("res://Assets/Sprites/SpanishDeck/DOS_DE_OROS.png")]
        DOS_DE_OROS = 1,
        [EnumValue("res://Assets/Sprites/SpanishDeck/CUATRO_DE_OROS.png")]
        CUATRO_DE_OROS = 2,
        [EnumValue("res://Assets/Sprites/SpanishDeck/CINCO_DE_OROS.png")]
        CINCO_DE_OROS = 3,
        [EnumValue("res://Assets/Sprites/SpanishDeck/SEIS_DE_OROS.png")]
        SEIS_DE_OROS = 4,
        [EnumValue("res://Assets/Sprites/SpanishDeck/SIETE_DE_OROS.png")]
        SIETE_DE_OROS = 5,
        [EnumValue("res://Assets/Sprites/SpanishDeck/SOTA_DE_OROS.png")]
        SOTA_DE_OROS = 6,
        [EnumValue("res://Assets/Sprites/SpanishDeck/CABALLO_DE_OROS.png")]
        CABALLO_DE_OROS = 7,
        [EnumValue("res://Assets/Sprites/SpanishDeck/REY_DE_OROS.png")]
        REY_DE_OROS = 8,
        [EnumValue("res://Assets/Sprites/SpanishDeck/TRES_DE_OROS.png")]
        TRES_DE_OROS = 9,
        [EnumValue("res://Assets/Sprites/SpanishDeck/AS_DE_OROS.png")]
        AS_DE_OROS = 10,
        [EnumValue("res://Assets/Sprites/SpanishDeck/DOS_DE_COPAS.png")]
        DOS_DE_COPAS = 11,
        [EnumValue("res://Assets/Sprites/SpanishDeck/CUATRO_DE_COPAS.png")]
        CUATRO_DE_COPAS = 12,
        [EnumValue("res://Assets/Sprites/SpanishDeck/CINCO_DE_COPAS.png")]
        CINCO_DE_COPAS = 13,
        [EnumValue("res://Assets/Sprites/SpanishDeck/SEIS_DE_COPAS.png")]
        SEIS_DE_COPAS = 14,
        [EnumValue("res://Assets/Sprites/SpanishDeck/SIETE_DE_COPAS.png")]
        SIETE_DE_COPAS = 15,
        [EnumValue("res://Assets/Sprites/SpanishDeck/SOTA_DE_COPAS.png")]
        SOTA_DE_COPAS = 16,
        [EnumValue("res://Assets/Sprites/SpanishDeck/CABALLO_DE_COPAS.png")]
        CABALLO_DE_COPAS = 17,
        [EnumValue("res://Assets/Sprites/SpanishDeck/REY_DE_COPAS.png")]
        REY_DE_COPAS = 18,
        [EnumValue("res://Assets/Sprites/SpanishDeck/TRES_DE_COPAS.png")]
        TRES_DE_COPAS = 19,
        [EnumValue("res://Assets/Sprites/SpanishDeck/AS_DE_COPAS.png")]
        AS_DE_COPAS = 20,
        [EnumValue("res://Assets/Sprites/SpanishDeck/DOS_DE_ESPADAS.png")]
        DOS_DE_ESPADAS = 21,
        [EnumValue("res://Assets/Sprites/SpanishDeck/CUATRO_DE_ESPADAS.png")]
        CUATRO_DE_ESPADAS = 22,
        [EnumValue("res://Assets/Sprites/SpanishDeck/CINCO_DE_ESPADAS.png")]
        CINCO_DE_ESPADAS = 23,
        [EnumValue("res://Assets/Sprites/SpanishDeck/SEIS_DE_ESPADAS.png")]
        SEIS_DE_ESPADAS = 24,
        [EnumValue("res://Assets/Sprites/SpanishDeck/SIETE_DE_ESPADAS.png")]
        SIETE_DE_ESPADAS = 25,
        [EnumValue("res://Assets/Sprites/SpanishDeck/SOTA_DE_ESPADAS.png")]
        SOTA_DE_ESPADAS = 26,
        [EnumValue("res://Assets/Sprites/SpanishDeck/CABALLO_DE_ESPADAS.png")]
        CABALLO_DE_ESPADAS = 27,
        [EnumValue("res://Assets/Sprites/SpanishDeck/REY_DE_ESPADAS.png")]
        REY_DE_ESPADAS = 28,
        [EnumValue("res://Assets/Sprites/SpanishDeck/TRES_DE_ESPADAS.png")]
        TRES_DE_ESPADAS = 29,
        [EnumValue("res://Assets/Sprites/SpanishDeck/AS_DE_ESPADAS.png")]
        AS_DE_ESPADAS = 30,
        [EnumValue("res://Assets/Sprites/SpanishDeck/DOS_DE_BASTOS.png")]
        DOS_DE_BASTOS = 31,
        [EnumValue("res://Assets/Sprites/SpanishDeck/CUATRO_DE_BASTOS.png")]
        CUATRO_DE_BASTOS = 32,
        [EnumValue("res://Assets/Sprites/SpanishDeck/CINCO_DE_BASTOS.png")]
        CINCO_DE_BASTOS = 33,
        [EnumValue("res://Assets/Sprites/SpanishDeck/SEIS_DE_BASTOS.png")]
        SEIS_DE_BASTOS = 34,
        [EnumValue("res://Assets/Sprites/SpanishDeck/SIETE_DE_BASTOS.png")]
        SIETE_DE_BASTOS = 35,
        [EnumValue("res://Assets/Sprites/SpanishDeck/SOTA_DE_BASTOS.png")]
        SOTA_DE_BASTOS = 36,
        [EnumValue("res://Assets/Sprites/SpanishDeck/CABALLO_DE_BASTOS.png")]
        CABALLO_DE_BASTOS = 37,
        [EnumValue("res://Assets/Sprites/SpanishDeck/REY_DE_BASTOS.png")]
        REY_DE_BASTOS = 38,
        [EnumValue("res://Assets/Sprites/SpanishDeck/TRES_DE_BASTOS.png")]
        TRES_DE_BASTOS = 39,
        [EnumValue("res://Assets/Sprites/SpanishDeck/AS_DE_BASTOS.png")]
        AS_DE_BASTOS = 40
    }

    public enum Dorsos
    {
        [EnumValue("res://Assets/Sprites/Dorsos/DORSO_BASICO.png")]
        DORSO_BASICO
    }

    public class EnumValueAttribute : Attribute
    {
        public string Value { get; }
        public EnumValueAttribute(string value)
        {
            Value = value;
        }
    }

    public class EnumHelper
    {
        /// <summary>
        /// Method to retrieve the string value asociated with an enumerate value
        /// </summary>
        /// <param name="value">Sprite value.</param>
        /// <returns>Its string value stablished on its definition.</returns>
        public static string GetSpriteURLValue(BarajaEspanola value)
        {
            var field = typeof(BarajaEspanola).GetField(value.ToString());
            var attribute = (EnumValueAttribute)Attribute.GetCustomAttribute(field, typeof(EnumValueAttribute));
            return attribute?.Value ?? string.Empty;
        }

        public static string GetSpriteURLValue(Dorsos value)
        {
            var field = typeof(Dorsos).GetField(value.ToString());
            var attribute = (EnumValueAttribute)Attribute.GetCustomAttribute(field,typeof(EnumValueAttribute));
            return attribute?.Value ?? string.Empty;
        }
    }
    public class Barajas
    {

    }
}
