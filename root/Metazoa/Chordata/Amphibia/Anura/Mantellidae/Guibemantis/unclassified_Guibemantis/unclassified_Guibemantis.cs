using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Mantellidae.Guibemantis;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Mantellidae.Guibemantis.unclassified_Guibemantis;

/// <summary>
/// Abstract class for unclassified Guibemantis (no rank).
/// NCBI TaxId: 647572
/// </summary>
public abstract class unclassified_Guibemantis : Guibemantis, Iunclassified_Guibemantis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Guibemantis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 647572;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Guibemantis";
}
