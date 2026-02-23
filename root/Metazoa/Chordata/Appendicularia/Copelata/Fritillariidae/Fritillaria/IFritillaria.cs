namespace AnimalKingdom.root.Metazoa.Chordata.Appendicularia.Copelata.Fritillariidae.Fritillaria;

/// <summary>
/// Interface defining characteristics of Fritillaria (genus).
/// </summary>
public interface IFritillaria
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
