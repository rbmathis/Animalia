namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Spintherobolidae.Spintherobolus;

/// <summary>
/// Interface defining characteristics of Spintherobolus (genus).
/// </summary>
public interface ISpintherobolus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
