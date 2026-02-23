namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Amiiformes.Amiidae.Amia;

/// <summary>
/// Interface defining characteristics of Amia (genus).
/// </summary>
public interface IAmia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
