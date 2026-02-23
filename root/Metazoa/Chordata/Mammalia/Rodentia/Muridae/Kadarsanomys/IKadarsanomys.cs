namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Kadarsanomys;

/// <summary>
/// Interface defining characteristics of Kadarsanomys (genus).
/// </summary>
public interface IKadarsanomys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
