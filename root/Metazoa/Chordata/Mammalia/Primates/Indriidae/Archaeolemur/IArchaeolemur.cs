namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Indriidae.Archaeolemur;

/// <summary>
/// Interface defining characteristics of Archaeolemur (genus).
/// </summary>
public interface IArchaeolemur
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
