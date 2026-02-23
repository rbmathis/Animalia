namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Ptilostomus;

/// <summary>
/// Interface defining characteristics of Ptilostomus (genus).
/// </summary>
public interface IPtilostomus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
