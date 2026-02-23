using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pyxicephalidae.Arthroleptella;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pyxicephalidae.Arthroleptella.unclassified_Arthroleptella;

/// <summary>
/// Abstract class for unclassified Arthroleptella (no rank).
/// NCBI TaxId: 2638790
/// </summary>
public abstract class unclassified_Arthroleptella : Arthroleptella, Iunclassified_Arthroleptella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Arthroleptella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2638790;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Arthroleptella";
}
