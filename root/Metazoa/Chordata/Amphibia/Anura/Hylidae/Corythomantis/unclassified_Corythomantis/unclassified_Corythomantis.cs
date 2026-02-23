using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Corythomantis;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Corythomantis.unclassified_Corythomantis;

/// <summary>
/// Abstract class for unclassified Corythomantis (no rank).
/// NCBI TaxId: 2787187
/// </summary>
public abstract class unclassified_Corythomantis : Corythomantis, Iunclassified_Corythomantis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Corythomantis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2787187;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Corythomantis";
}
