namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Chlorophthalmidae.Chlorophthalmus;

/// <summary>
/// Interface defining characteristics of Chlorophthalmus (genus).
/// </summary>
public interface IChlorophthalmus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
