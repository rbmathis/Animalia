namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Elopiformes.Elopidae.Elops;

/// <summary>
/// Interface defining characteristics of Elops (genus).
/// </summary>
public interface IElops
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
