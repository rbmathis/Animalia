using AnimalKingdom.root.Metazoa.Chordata.Aves.Suliformes.Fregatidae.Fregata;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Suliformes.Fregatidae.Fregata.unclassified_Fregata;

/// <summary>
/// Abstract class for unclassified Fregata (no rank).
/// NCBI TaxId: 2620211
/// </summary>
public abstract class unclassified_Fregata : Fregata, Iunclassified_Fregata
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Fregata";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2620211;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Fregata";
}
