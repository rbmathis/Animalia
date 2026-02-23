namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae.Paraconger;

/// <summary>
/// Interface defining characteristics of Paraconger (genus).
/// </summary>
public interface IParaconger
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
