namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Stochomys;

/// <summary>
/// Interface defining characteristics of Stochomys (genus).
/// </summary>
public interface IStochomys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
