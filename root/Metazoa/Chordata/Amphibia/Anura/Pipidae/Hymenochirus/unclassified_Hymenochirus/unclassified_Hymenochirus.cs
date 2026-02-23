using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pipidae.Hymenochirus;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pipidae.Hymenochirus.unclassified_Hymenochirus;

/// <summary>
/// Abstract class for unclassified Hymenochirus (no rank).
/// NCBI TaxId: 2640468
/// </summary>
public abstract class unclassified_Hymenochirus : Hymenochirus, Iunclassified_Hymenochirus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hymenochirus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640468;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hymenochirus";
}
