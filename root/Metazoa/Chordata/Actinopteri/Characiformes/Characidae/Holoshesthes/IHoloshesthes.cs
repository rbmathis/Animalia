namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Holoshesthes;

/// <summary>
/// Interface defining characteristics of Holoshesthes (genus).
/// </summary>
public interface IHoloshesthes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
