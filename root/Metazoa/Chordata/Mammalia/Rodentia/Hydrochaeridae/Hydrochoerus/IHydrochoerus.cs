namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Hydrochaeridae.Hydrochoerus;

/// <summary>
/// Interface defining characteristics of Hydrochoerus (genus).
/// </summary>
public interface IHydrochoerus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
