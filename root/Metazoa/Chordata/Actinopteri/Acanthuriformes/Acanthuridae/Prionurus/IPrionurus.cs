namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acanthuriformes.Acanthuridae.Prionurus;

/// <summary>
/// Interface defining characteristics of Prionurus (genus).
/// </summary>
public interface IPrionurus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
