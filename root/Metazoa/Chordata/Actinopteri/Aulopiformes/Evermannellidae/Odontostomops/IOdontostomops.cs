namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Evermannellidae.Odontostomops;

/// <summary>
/// Interface defining characteristics of Odontostomops (genus).
/// </summary>
public interface IOdontostomops
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
