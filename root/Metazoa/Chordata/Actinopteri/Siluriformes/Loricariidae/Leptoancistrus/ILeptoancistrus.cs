namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Leptoancistrus;

/// <summary>
/// Interface defining characteristics of Leptoancistrus (genus).
/// </summary>
public interface ILeptoancistrus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
