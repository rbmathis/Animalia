namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Chiromyscus;

/// <summary>
/// Interface defining characteristics of Chiromyscus (genus).
/// </summary>
public interface IChiromyscus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
