namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Melanocharitidae.Oedistoma;

/// <summary>
/// Interface defining characteristics of Oedistoma (genus).
/// </summary>
public interface IOedistoma
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
