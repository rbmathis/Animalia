namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Lateolabracidae.Lateolabrax;

/// <summary>
/// Interface defining characteristics of Lateolabrax (genus).
/// </summary>
public interface ILateolabrax
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
