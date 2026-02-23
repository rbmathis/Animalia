namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Phloeomys;

/// <summary>
/// Interface defining characteristics of Phloeomys (genus).
/// </summary>
public interface IPhloeomys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
