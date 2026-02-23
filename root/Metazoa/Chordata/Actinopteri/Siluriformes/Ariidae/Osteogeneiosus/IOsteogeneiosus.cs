namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae.Osteogeneiosus;

/// <summary>
/// Interface defining characteristics of Osteogeneiosus (genus).
/// </summary>
public interface IOsteogeneiosus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
