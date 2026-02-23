using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Siluridae.Kryptopterus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Siluridae.Kryptopterus.unclassified_Kryptopterus;

/// <summary>
/// Abstract class for unclassified Kryptopterus (no rank).
/// NCBI TaxId: 2628900
/// </summary>
public abstract class unclassified_Kryptopterus : Kryptopterus, Iunclassified_Kryptopterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Kryptopterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2628900;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Kryptopterus";
}
