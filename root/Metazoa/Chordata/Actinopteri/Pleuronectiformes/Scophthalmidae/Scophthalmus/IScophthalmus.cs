namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Scophthalmidae.Scophthalmus;

/// <summary>
/// Interface defining characteristics of Scophthalmus (genus).
/// </summary>
public interface IScophthalmus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
