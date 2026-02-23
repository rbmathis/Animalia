namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Notocheiridae.Notocheirus;

/// <summary>
/// Interface defining characteristics of Notocheirus (genus).
/// </summary>
public interface INotocheirus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
