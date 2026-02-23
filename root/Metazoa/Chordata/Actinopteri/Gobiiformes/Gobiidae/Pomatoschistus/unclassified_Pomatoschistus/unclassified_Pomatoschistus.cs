using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Pomatoschistus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Pomatoschistus.unclassified_Pomatoschistus;

/// <summary>
/// Abstract class for unclassified Pomatoschistus (no rank).
/// NCBI TaxId: 2636023
/// </summary>
public abstract class unclassified_Pomatoschistus : Pomatoschistus, Iunclassified_Pomatoschistus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pomatoschistus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2636023;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pomatoschistus";
}
