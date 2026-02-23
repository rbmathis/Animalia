namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae.Coryphaenoides;

/// <summary>
/// Interface defining characteristics of Coryphaenoides (genus).
/// </summary>
public interface ICoryphaenoides
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
