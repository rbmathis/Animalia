namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Hypophthalmichthys;

/// <summary>
/// Interface defining characteristics of Hypophthalmichthys (genus).
/// </summary>
public interface IHypophthalmichthys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
