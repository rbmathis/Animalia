using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ceratobatrachidae.Platymantis;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ceratobatrachidae.Platymantis.unclassified_Platymantis;

/// <summary>
/// Abstract class for unclassified Platymantis (no rank).
/// NCBI TaxId: 2635867
/// </summary>
public abstract class unclassified_Platymantis : Platymantis, Iunclassified_Platymantis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Platymantis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2635867;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Platymantis";
}
