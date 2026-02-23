namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ephippiformes.Ephippidae.Platax;

/// <summary>
/// Interface defining characteristics of Platax (genus).
/// </summary>
public interface IPlatax
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
