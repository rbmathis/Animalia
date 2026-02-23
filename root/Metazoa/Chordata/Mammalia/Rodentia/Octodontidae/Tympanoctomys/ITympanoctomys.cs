namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Octodontidae.Tympanoctomys;

/// <summary>
/// Interface defining characteristics of Tympanoctomys (genus).
/// </summary>
public interface ITympanoctomys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
