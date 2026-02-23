namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Trionychidae.Cyclanorbis;

/// <summary>
/// Interface defining characteristics of Cyclanorbis (genus).
/// </summary>
public interface ICyclanorbis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
