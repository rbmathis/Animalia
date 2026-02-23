namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae.Myadestes;

/// <summary>
/// Interface defining characteristics of Myadestes (genus).
/// </summary>
public interface IMyadestes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
