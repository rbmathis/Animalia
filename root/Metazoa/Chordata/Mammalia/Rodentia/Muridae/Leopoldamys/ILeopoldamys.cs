namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Leopoldamys;

/// <summary>
/// Interface defining characteristics of Leopoldamys (genus).
/// </summary>
public interface ILeopoldamys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
