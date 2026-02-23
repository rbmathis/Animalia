namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Pomatoschistus;

/// <summary>
/// Interface defining characteristics of Pomatoschistus (genus).
/// </summary>
public interface IPomatoschistus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
