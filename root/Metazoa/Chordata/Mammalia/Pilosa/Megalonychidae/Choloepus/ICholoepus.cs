namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Pilosa.Megalonychidae.Choloepus;

/// <summary>
/// Interface defining characteristics of Choloepus (genus).
/// </summary>
public interface ICholoepus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
