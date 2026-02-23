namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Scopelarchidae.Benthalbella;

/// <summary>
/// Interface defining characteristics of Benthalbella (genus).
/// </summary>
public interface IBenthalbella
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
