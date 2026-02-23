namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Heleophrynidae.Heleophryne;

/// <summary>
/// Interface defining characteristics of Heleophryne (genus).
/// </summary>
public interface IHeleophryne
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
