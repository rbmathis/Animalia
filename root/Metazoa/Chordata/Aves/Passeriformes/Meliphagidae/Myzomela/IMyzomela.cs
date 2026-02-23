namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae.Myzomela;

/// <summary>
/// Interface defining characteristics of Myzomela (genus).
/// </summary>
public interface IMyzomela
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
