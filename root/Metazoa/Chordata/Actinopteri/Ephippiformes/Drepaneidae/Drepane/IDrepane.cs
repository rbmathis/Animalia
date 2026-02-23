namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ephippiformes.Drepaneidae.Drepane;

/// <summary>
/// Interface defining characteristics of Drepane (genus).
/// </summary>
public interface IDrepane
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
