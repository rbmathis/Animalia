namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Eoglaucomys;

/// <summary>
/// Interface defining characteristics of Eoglaucomys (genus).
/// </summary>
public interface IEoglaucomys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
