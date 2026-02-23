namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Scandentia.Tupaiidae.Ptilocercus;

/// <summary>
/// Interface defining characteristics of Ptilocercus (genus).
/// </summary>
public interface IPtilocercus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
