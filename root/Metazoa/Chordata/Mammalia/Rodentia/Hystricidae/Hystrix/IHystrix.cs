namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Hystricidae.Hystrix;

/// <summary>
/// Interface defining characteristics of Hystrix (genus).
/// </summary>
public interface IHystrix
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
