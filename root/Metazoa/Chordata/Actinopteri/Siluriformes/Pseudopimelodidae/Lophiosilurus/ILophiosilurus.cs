namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pseudopimelodidae.Lophiosilurus;

/// <summary>
/// Interface defining characteristics of Lophiosilurus (genus).
/// </summary>
public interface ILophiosilurus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
