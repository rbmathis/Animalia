namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Pilosa.Mylodontidae.Mylodon;

/// <summary>
/// Interface defining characteristics of Mylodon (genus).
/// </summary>
public interface IMylodon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
