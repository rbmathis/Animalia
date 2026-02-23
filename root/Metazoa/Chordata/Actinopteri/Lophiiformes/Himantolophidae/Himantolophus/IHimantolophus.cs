namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Himantolophidae.Himantolophus;

/// <summary>
/// Interface defining characteristics of Himantolophus (genus).
/// </summary>
public interface IHimantolophus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
