using AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Phrynops;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Phrynops.unclassified_Phrynops;

/// <summary>
/// Abstract class for unclassified Phrynops (no rank).
/// NCBI TaxId: 2648216
/// </summary>
public abstract class unclassified_Phrynops : Phrynops, Iunclassified_Phrynops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Phrynops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2648216;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Phrynops";
}
