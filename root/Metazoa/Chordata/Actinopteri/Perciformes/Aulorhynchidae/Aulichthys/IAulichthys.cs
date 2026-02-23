namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Aulorhynchidae.Aulichthys;

/// <summary>
/// Interface defining characteristics of Aulichthys (genus).
/// </summary>
public interface IAulichthys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
