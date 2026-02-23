namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Allophrynidae.Allophryne;

/// <summary>
/// Interface defining characteristics of Allophryne (genus).
/// </summary>
public interface IAllophryne
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
