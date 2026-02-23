namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Oneirodidae.Lophodolos;

/// <summary>
/// Interface defining characteristics of Lophodolos (genus).
/// </summary>
public interface ILophodolos
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
