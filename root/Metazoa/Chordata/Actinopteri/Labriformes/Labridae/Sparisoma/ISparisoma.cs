namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Sparisoma;

/// <summary>
/// Interface defining characteristics of Sparisoma (genus).
/// </summary>
public interface ISparisoma
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
