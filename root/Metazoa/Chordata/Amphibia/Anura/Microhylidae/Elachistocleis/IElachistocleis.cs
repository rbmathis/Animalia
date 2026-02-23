namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Elachistocleis;

/// <summary>
/// Interface defining characteristics of Elachistocleis (genus).
/// </summary>
public interface IElachistocleis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
