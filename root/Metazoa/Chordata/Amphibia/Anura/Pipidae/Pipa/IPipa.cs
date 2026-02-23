namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pipidae.Pipa;

/// <summary>
/// Interface defining characteristics of Pipa (genus).
/// </summary>
public interface IPipa
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
