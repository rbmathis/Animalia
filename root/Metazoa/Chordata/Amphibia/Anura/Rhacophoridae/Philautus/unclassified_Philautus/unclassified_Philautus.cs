using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae.Philautus;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae.Philautus.unclassified_Philautus;

/// <summary>
/// Abstract class for unclassified Philautus (no rank).
/// NCBI TaxId: 2632255
/// </summary>
public abstract class unclassified_Philautus : Philautus, Iunclassified_Philautus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Philautus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2632255;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Philautus";
}
