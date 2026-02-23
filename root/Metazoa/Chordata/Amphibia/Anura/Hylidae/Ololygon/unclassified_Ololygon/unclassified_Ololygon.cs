using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Ololygon;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Ololygon.unclassified_Ololygon;

/// <summary>
/// Abstract class for unclassified Ololygon (no rank).
/// NCBI TaxId: 3045453
/// </summary>
public abstract class unclassified_Ololygon : Ololygon, Iunclassified_Ololygon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ololygon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3045453;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ololygon";
}
