namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Scopelarchidae.Scopelarchoides;

/// <summary>
/// Interface defining characteristics of Scopelarchoides (genus).
/// </summary>
public interface IScopelarchoides
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
