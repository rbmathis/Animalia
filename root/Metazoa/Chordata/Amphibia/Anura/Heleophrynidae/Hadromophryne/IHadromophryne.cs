namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Heleophrynidae.Hadromophryne;

/// <summary>
/// Interface defining characteristics of Hadromophryne (genus).
/// </summary>
public interface IHadromophryne
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
