namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae.Liza;

/// <summary>
/// Interface defining characteristics of Liza (genus).
/// </summary>
public interface ILiza
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
