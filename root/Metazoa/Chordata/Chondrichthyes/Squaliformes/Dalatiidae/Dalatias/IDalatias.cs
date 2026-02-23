namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Dalatiidae.Dalatias;

/// <summary>
/// Interface defining characteristics of Dalatias (genus).
/// </summary>
public interface IDalatias
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
