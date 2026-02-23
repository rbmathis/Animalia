namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Meiglyptes;

/// <summary>
/// Interface defining characteristics of Meiglyptes (genus).
/// </summary>
public interface IMeiglyptes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
