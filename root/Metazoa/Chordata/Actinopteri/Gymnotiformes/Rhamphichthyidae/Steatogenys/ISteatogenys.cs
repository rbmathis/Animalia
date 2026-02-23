namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Rhamphichthyidae.Steatogenys;

/// <summary>
/// Interface defining characteristics of Steatogenys (genus).
/// </summary>
public interface ISteatogenys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
