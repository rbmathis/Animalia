namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Champsodontidae.Champsodon;

/// <summary>
/// Interface defining characteristics of Champsodon (genus).
/// </summary>
public interface IChampsodon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
