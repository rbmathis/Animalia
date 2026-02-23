namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Agalychnis;

/// <summary>
/// Interface defining characteristics of Agalychnis (genus).
/// </summary>
public interface IAgalychnis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
