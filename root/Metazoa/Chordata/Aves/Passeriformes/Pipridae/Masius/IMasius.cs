namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pipridae.Masius;

/// <summary>
/// Interface defining characteristics of Masius (genus).
/// </summary>
public interface IMasius
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
