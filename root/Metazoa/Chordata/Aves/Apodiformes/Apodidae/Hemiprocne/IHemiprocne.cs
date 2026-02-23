namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Apodidae.Hemiprocne;

/// <summary>
/// Interface defining characteristics of Hemiprocne (genus).
/// </summary>
public interface IHemiprocne
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
