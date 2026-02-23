using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pyxicephalidae.Amietia;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pyxicephalidae.Amietia.unclassified_Amietia;

/// <summary>
/// Abstract class for unclassified Amietia (no rank).
/// NCBI TaxId: 2645660
/// </summary>
public abstract class unclassified_Amietia : Amietia, Iunclassified_Amietia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Amietia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2645660;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Amietia";
}
