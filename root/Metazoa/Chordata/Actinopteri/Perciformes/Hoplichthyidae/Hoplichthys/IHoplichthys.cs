namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Hoplichthyidae.Hoplichthys;

/// <summary>
/// Interface defining characteristics of Hoplichthys (genus).
/// </summary>
public interface IHoplichthys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
