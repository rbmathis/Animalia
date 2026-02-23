namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Polycitoridae.Archidistoma;

/// <summary>
/// Interface defining characteristics of Archidistoma (genus).
/// </summary>
public interface IArchidistoma
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
