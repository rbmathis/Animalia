namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Brucepattersonius;

/// <summary>
/// Interface defining characteristics of Brucepattersonius (genus).
/// </summary>
public interface IBrucepattersonius
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
