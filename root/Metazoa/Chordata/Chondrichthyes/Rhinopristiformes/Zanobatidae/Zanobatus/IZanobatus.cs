namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rhinopristiformes.Zanobatidae.Zanobatus;

/// <summary>
/// Interface defining characteristics of Zanobatus (genus).
/// </summary>
public interface IZanobatus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
