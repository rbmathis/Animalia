namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Alepocephaliformes.Platytroctidae.Mentodus;

/// <summary>
/// Interface defining characteristics of Mentodus (genus).
/// </summary>
public interface IMentodus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
