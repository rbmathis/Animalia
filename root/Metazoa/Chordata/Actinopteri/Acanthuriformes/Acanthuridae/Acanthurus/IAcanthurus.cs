namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acanthuriformes.Acanthuridae.Acanthurus;

/// <summary>
/// Interface defining characteristics of Acanthurus (genus).
/// </summary>
public interface IAcanthurus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
