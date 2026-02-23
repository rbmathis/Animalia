namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Leptagoniates;

/// <summary>
/// Interface defining characteristics of Leptagoniates (genus).
/// </summary>
public interface ILeptagoniates
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
