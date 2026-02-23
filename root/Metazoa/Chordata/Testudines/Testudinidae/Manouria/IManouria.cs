namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Manouria;

/// <summary>
/// Interface defining characteristics of Manouria (genus).
/// </summary>
public interface IManouria
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
