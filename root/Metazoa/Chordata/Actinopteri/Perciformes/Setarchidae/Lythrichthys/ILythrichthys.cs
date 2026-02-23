namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Setarchidae.Lythrichthys;

/// <summary>
/// Interface defining characteristics of Lythrichthys (genus).
/// </summary>
public interface ILythrichthys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
