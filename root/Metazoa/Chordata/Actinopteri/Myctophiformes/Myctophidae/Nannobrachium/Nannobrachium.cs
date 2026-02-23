using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae.Nannobrachium;

/// <summary>
/// Abstract class for Nannobrachium (genus).
/// NCBI TaxId: 153158
/// </summary>
public abstract class Nannobrachium : Myctophidae, INannobrachium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nannobrachium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 153158;

    /// <inheritdoc />
    public virtual string GenusName => "Nannobrachium";

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
