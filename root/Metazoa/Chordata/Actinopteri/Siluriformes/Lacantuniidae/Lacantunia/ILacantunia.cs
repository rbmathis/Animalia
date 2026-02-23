namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Lacantuniidae.Lacantunia;

/// <summary>
/// Interface defining characteristics of Lacantunia (genus).
/// </summary>
public interface ILacantunia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
