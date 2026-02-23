namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Epigonidae.Rosenblattia;

/// <summary>
/// Interface defining characteristics of Rosenblattia (genus).
/// </summary>
public interface IRosenblattia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
