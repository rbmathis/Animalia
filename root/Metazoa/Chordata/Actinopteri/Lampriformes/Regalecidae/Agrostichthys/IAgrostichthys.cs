namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lampriformes.Regalecidae.Agrostichthys;

/// <summary>
/// Interface defining characteristics of Agrostichthys (genus).
/// </summary>
public interface IAgrostichthys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
