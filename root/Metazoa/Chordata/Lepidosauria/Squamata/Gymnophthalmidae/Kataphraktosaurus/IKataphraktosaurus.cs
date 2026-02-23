namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Kataphraktosaurus;

/// <summary>
/// Interface defining characteristics of Kataphraktosaurus (genus).
/// </summary>
public interface IKataphraktosaurus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
