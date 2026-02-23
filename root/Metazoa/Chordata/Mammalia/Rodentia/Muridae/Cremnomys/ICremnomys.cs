namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Cremnomys;

/// <summary>
/// Interface defining characteristics of Cremnomys (genus).
/// </summary>
public interface ICremnomys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
