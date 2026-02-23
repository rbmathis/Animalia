namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Echiothrix;

/// <summary>
/// Interface defining characteristics of Echiothrix (genus).
/// </summary>
public interface IEchiothrix
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
