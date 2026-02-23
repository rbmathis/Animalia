namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Ochromyscus;

/// <summary>
/// Interface defining characteristics of Ochromyscus (genus).
/// </summary>
public interface IOchromyscus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
