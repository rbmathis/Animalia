using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Strabomantidae.Phrynopus;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Strabomantidae.Phrynopus.unclassified_Phrynopus;

/// <summary>
/// Abstract class for unclassified Phrynopus (no rank).
/// NCBI TaxId: 2626156
/// </summary>
public abstract class unclassified_Phrynopus : Phrynopus, Iunclassified_Phrynopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Phrynopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626156;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Phrynopus";
}
