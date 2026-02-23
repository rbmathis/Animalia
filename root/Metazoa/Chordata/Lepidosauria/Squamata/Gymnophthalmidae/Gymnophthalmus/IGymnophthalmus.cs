namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Gymnophthalmus;

/// <summary>
/// Interface defining characteristics of Gymnophthalmus (genus).
/// </summary>
public interface IGymnophthalmus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
