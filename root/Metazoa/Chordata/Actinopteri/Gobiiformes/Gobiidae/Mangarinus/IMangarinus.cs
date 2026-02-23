namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Mangarinus;

/// <summary>
/// Interface defining characteristics of Mangarinus (genus).
/// </summary>
public interface IMangarinus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
