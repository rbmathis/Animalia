namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Labrisomidae.Dialommus;

/// <summary>
/// Interface defining characteristics of Dialommus (genus).
/// </summary>
public interface IDialommus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
