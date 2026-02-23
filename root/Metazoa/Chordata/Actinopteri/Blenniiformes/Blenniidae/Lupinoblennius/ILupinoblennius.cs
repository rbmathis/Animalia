namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Lupinoblennius;

/// <summary>
/// Interface defining characteristics of Lupinoblennius (genus).
/// </summary>
public interface ILupinoblennius
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
