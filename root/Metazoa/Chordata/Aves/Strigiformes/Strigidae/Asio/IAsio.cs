namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Asio;

/// <summary>
/// Interface defining characteristics of Asio (genus).
/// </summary>
public interface IAsio
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
