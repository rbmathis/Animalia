namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Bathyclupeidae.Bathyclupea;

/// <summary>
/// Interface defining characteristics of Bathyclupea (genus).
/// </summary>
public interface IBathyclupea
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
