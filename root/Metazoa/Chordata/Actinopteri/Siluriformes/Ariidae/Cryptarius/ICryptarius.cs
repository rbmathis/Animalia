namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae.Cryptarius;

/// <summary>
/// Interface defining characteristics of Cryptarius (genus).
/// </summary>
public interface ICryptarius
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
