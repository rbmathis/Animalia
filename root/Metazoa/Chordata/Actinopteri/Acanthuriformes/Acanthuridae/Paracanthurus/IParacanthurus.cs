namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acanthuriformes.Acanthuridae.Paracanthurus;

/// <summary>
/// Interface defining characteristics of Paracanthurus (genus).
/// </summary>
public interface IParacanthurus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
