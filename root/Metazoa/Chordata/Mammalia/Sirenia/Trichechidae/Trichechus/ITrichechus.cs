namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Sirenia.Trichechidae.Trichechus;

/// <summary>
/// Interface defining characteristics of Trichechus (genus).
/// </summary>
public interface ITrichechus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
