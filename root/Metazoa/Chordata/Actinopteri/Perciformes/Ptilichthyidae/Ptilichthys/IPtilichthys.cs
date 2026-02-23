namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Ptilichthyidae.Ptilichthys;

/// <summary>
/// Interface defining characteristics of Ptilichthys (genus).
/// </summary>
public interface IPtilichthys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
