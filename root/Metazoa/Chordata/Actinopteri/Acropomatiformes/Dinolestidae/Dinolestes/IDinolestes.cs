namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Dinolestidae.Dinolestes;

/// <summary>
/// Interface defining characteristics of Dinolestes (genus).
/// </summary>
public interface IDinolestes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
