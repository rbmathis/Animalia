namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Batomys;

/// <summary>
/// Interface defining characteristics of Batomys (genus).
/// </summary>
public interface IBatomys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
