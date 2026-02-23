namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Mesoclemmys;

/// <summary>
/// Interface defining characteristics of Mesoclemmys (genus).
/// </summary>
public interface IMesoclemmys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
