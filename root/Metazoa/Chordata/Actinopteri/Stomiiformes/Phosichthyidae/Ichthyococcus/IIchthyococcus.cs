namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Phosichthyidae.Ichthyococcus;

/// <summary>
/// Interface defining characteristics of Ichthyococcus (genus).
/// </summary>
public interface IIchthyococcus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
