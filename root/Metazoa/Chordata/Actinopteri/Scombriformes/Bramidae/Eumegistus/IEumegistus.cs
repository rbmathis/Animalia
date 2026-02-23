namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Bramidae.Eumegistus;

/// <summary>
/// Interface defining characteristics of Eumegistus (genus).
/// </summary>
public interface IEumegistus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
