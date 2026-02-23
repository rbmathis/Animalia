namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Alepocephaliformes.Alepocephalidae.Leptoderma;

/// <summary>
/// Interface defining characteristics of Leptoderma (genus).
/// </summary>
public interface ILeptoderma
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
