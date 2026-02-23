namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Terapontidae.Terapon;

/// <summary>
/// Interface defining characteristics of Terapon (genus).
/// </summary>
public interface ITerapon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
