namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Craseonycteridae.Craseonycteris;

/// <summary>
/// Interface defining characteristics of Craseonycteris (genus).
/// </summary>
public interface ICraseonycteris
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
