namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Clariidae.Horaglanis;

/// <summary>
/// Interface defining characteristics of Horaglanis (genus).
/// </summary>
public interface IHoraglanis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
