using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Parulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Parulidae.Xenoligea;

/// <summary>
/// Abstract class for Xenoligea (genus).
/// NCBI TaxId: 182952
/// </summary>
public abstract class Xenoligea : Parulidae, IXenoligea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xenoligea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 182952;

    /// <inheritdoc />
    public virtual string GenusName => "Xenoligea";

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
