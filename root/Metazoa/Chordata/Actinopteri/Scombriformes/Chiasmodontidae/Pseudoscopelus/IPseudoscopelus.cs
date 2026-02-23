namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Chiasmodontidae.Pseudoscopelus;

/// <summary>
/// Interface defining characteristics of Pseudoscopelus (genus).
/// </summary>
public interface IPseudoscopelus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
