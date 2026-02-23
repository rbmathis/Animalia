namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Burramyidae.Burramys;

/// <summary>
/// Interface defining characteristics of Burramys (genus).
/// </summary>
public interface IBurramys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
