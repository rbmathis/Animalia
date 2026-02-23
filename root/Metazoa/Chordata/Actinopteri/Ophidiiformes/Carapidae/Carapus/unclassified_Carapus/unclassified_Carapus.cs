using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Carapidae.Carapus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Carapidae.Carapus.unclassified_Carapus;

/// <summary>
/// Abstract class for unclassified Carapus (no rank).
/// NCBI TaxId: 2625989
/// </summary>
public abstract class unclassified_Carapus : Carapus, Iunclassified_Carapus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Carapus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2625989;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Carapus";
}
