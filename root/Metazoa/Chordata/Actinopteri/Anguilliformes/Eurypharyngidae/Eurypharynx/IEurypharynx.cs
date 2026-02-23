namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Eurypharyngidae.Eurypharynx;

/// <summary>
/// Interface defining characteristics of Eurypharynx (genus).
/// </summary>
public interface IEurypharynx
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
