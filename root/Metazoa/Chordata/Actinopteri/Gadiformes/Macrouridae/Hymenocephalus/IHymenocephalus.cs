namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae.Hymenocephalus;

/// <summary>
/// Interface defining characteristics of Hymenocephalus (genus).
/// </summary>
public interface IHymenocephalus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
