using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Parulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Parulidae.Microligea;

/// <summary>
/// Abstract class for Microligea (genus).
/// NCBI TaxId: 182933
/// </summary>
public abstract class Microligea : Parulidae, IMicroligea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Microligea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 182933;

    /// <inheritdoc />
    public virtual string GenusName => "Microligea";

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
