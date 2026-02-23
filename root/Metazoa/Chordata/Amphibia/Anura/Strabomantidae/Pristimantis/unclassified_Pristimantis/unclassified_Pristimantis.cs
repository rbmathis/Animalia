using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Strabomantidae.Pristimantis;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Strabomantidae.Pristimantis.unclassified_Pristimantis;

/// <summary>
/// Abstract class for unclassified Pristimantis (no rank).
/// NCBI TaxId: 2647445
/// </summary>
public abstract class unclassified_Pristimantis : Pristimantis, Iunclassified_Pristimantis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pristimantis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2647445;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pristimantis";
}
