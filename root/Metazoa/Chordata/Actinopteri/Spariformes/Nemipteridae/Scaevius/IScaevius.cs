namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Nemipteridae.Scaevius;

/// <summary>
/// Interface defining characteristics of Scaevius (genus).
/// </summary>
public interface IScaevius
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
