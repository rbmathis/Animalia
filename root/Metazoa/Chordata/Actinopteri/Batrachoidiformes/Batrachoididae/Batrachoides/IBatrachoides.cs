namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Batrachoidiformes.Batrachoididae.Batrachoides;

/// <summary>
/// Interface defining characteristics of Batrachoides (genus).
/// </summary>
public interface IBatrachoides
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
