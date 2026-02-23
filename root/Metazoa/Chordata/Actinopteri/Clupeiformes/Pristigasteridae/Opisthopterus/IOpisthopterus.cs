namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Pristigasteridae.Opisthopterus;

/// <summary>
/// Interface defining characteristics of Opisthopterus (genus).
/// </summary>
public interface IOpisthopterus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
