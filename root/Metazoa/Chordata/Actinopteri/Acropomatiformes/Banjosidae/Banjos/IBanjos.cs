namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Banjosidae.Banjos;

/// <summary>
/// Interface defining characteristics of Banjos (genus).
/// </summary>
public interface IBanjos
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
