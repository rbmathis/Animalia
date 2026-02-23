namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Cetomimidae.Parataeniophorus;

/// <summary>
/// Interface defining characteristics of Parataeniophorus (genus).
/// </summary>
public interface IParataeniophorus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
