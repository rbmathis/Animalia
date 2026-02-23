namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lepidogalaxiiformes.Lepidogalaxias;

/// <summary>
/// Interface defining characteristics of Lepidogalaxias (genus).
/// </summary>
public interface ILepidogalaxias
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
