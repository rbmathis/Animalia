namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Dicruridae.Dicrurus;

/// <summary>
/// Interface defining characteristics of Dicrurus (genus).
/// </summary>
public interface IDicrurus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
