namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Galaxiiformes.Galaxiidae.Neochanna;

/// <summary>
/// Interface defining characteristics of Neochanna (genus).
/// </summary>
public interface INeochanna
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
