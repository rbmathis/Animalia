namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Numididae.Guttera;

/// <summary>
/// Interface defining characteristics of Guttera (genus).
/// </summary>
public interface IGuttera
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
