namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.Sphaeramia;

/// <summary>
/// Interface defining characteristics of Sphaeramia (genus).
/// </summary>
public interface ISphaeramia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
