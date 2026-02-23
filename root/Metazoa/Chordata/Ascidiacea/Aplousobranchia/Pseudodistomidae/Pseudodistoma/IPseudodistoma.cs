namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Pseudodistomidae.Pseudodistoma;

/// <summary>
/// Interface defining characteristics of Pseudodistoma (genus).
/// </summary>
public interface IPseudodistoma
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
