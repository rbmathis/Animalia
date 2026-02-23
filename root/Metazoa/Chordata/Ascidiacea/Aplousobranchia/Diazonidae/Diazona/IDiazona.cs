namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Diazonidae.Diazona;

/// <summary>
/// Interface defining characteristics of Diazona (genus).
/// </summary>
public interface IDiazona
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
