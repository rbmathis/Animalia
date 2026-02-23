using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Phrynomantis;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Phrynomantis.unclassified_Phrynomantis;

/// <summary>
/// Abstract class for unclassified Phrynomantis (no rank).
/// NCBI TaxId: 2626346
/// </summary>
public abstract class unclassified_Phrynomantis : Phrynomantis, Iunclassified_Phrynomantis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Phrynomantis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626346;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Phrynomantis";
}
