namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pseudochromidae.Labracinus;

/// <summary>
/// Interface defining characteristics of Labracinus (genus).
/// </summary>
public interface ILabracinus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
