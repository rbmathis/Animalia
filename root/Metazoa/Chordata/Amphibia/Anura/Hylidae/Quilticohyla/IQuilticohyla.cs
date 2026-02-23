namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Quilticohyla;

/// <summary>
/// Interface defining characteristics of Quilticohyla (genus).
/// </summary>
public interface IQuilticohyla
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
