using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Strabomantidae.Tachiramantis;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Strabomantidae.Tachiramantis.unclassified_Tachiramantis;

/// <summary>
/// Abstract class for unclassified Tachiramantis (no rank).
/// NCBI TaxId: 3455612
/// </summary>
public abstract class unclassified_Tachiramantis : Tachiramantis, Iunclassified_Tachiramantis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Tachiramantis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3455612;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Tachiramantis";
}
