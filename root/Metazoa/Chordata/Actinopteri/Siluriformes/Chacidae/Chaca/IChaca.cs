namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Chacidae.Chaca;

/// <summary>
/// Interface defining characteristics of Chaca (genus).
/// </summary>
public interface IChaca
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
