namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Badidae.Badis;

/// <summary>
/// Interface defining characteristics of Badis (genus).
/// </summary>
public interface IBadis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
