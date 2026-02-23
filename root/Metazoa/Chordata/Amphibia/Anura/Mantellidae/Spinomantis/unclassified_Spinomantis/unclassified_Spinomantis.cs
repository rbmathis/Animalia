using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Mantellidae.Spinomantis;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Mantellidae.Spinomantis.unclassified_Spinomantis;

/// <summary>
/// Abstract class for unclassified Spinomantis (no rank).
/// NCBI TaxId: 2685378
/// </summary>
public abstract class unclassified_Spinomantis : Spinomantis, Iunclassified_Spinomantis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Spinomantis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2685378;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Spinomantis";
}
