namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Myocastoridae.Myocastor;

/// <summary>
/// Interface defining characteristics of Myocastor (genus).
/// </summary>
public interface IMyocastor
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
