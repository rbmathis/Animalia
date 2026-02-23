namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Synoicidae.Amaroucium;

/// <summary>
/// Interface defining characteristics of Amaroucium (genus).
/// </summary>
public interface IAmaroucium
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
