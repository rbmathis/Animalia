using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Ptilostomus;

/// <summary>
/// Abstract class for Ptilostomus (genus).
/// NCBI TaxId: 56793
/// </summary>
public abstract class Ptilostomus : Corvidae, IPtilostomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ptilostomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 56793;

    /// <inheritdoc />
    public virtual string GenusName => "Ptilostomus";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
