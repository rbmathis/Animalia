namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Kaieteurosaurus;

/// <summary>
/// Interface defining characteristics of Kaieteurosaurus (genus).
/// </summary>
public interface IKaieteurosaurus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
