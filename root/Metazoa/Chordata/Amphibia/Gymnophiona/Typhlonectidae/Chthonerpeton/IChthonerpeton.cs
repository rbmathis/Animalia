namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Typhlonectidae.Chthonerpeton;

/// <summary>
/// Interface defining characteristics of Chthonerpeton (genus).
/// </summary>
public interface IChthonerpeton
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
