namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Synbranchiformes.Mastacembelidae.Mastacembelus;

/// <summary>
/// Interface defining characteristics of Mastacembelus (genus).
/// </summary>
public interface IMastacembelus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
