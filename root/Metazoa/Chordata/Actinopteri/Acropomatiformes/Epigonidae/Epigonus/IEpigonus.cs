namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Epigonidae.Epigonus;

/// <summary>
/// Interface defining characteristics of Epigonus (genus).
/// </summary>
public interface IEpigonus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
