namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Heterenchelyidae.Pythonichthys;

/// <summary>
/// Interface defining characteristics of Pythonichthys (genus).
/// </summary>
public interface IPythonichthys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
