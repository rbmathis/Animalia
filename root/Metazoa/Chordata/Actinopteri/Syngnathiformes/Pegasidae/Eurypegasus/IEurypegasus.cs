namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Pegasidae.Eurypegasus;

/// <summary>
/// Interface defining characteristics of Eurypegasus (genus).
/// </summary>
public interface IEurypegasus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
