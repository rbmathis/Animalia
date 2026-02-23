namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Oplegnathidae.Oplegnathus;

/// <summary>
/// Interface defining characteristics of Oplegnathus (genus).
/// </summary>
public interface IOplegnathus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
