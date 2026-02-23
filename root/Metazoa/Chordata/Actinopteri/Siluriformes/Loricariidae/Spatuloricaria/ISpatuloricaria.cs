namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Spatuloricaria;

/// <summary>
/// Interface defining characteristics of Spatuloricaria (genus).
/// </summary>
public interface ISpatuloricaria
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
