namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Colocongridae.Coloconger;

/// <summary>
/// Interface defining characteristics of Coloconger (genus).
/// </summary>
public interface IColoconger
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
