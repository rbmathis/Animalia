namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pangasiidae.Helicophagus;

/// <summary>
/// Interface defining characteristics of Helicophagus (genus).
/// </summary>
public interface IHelicophagus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
