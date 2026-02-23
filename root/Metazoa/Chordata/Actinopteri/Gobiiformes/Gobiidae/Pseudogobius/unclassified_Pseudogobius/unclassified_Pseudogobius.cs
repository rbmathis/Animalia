using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Pseudogobius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Pseudogobius.unclassified_Pseudogobius;

/// <summary>
/// Abstract class for unclassified Pseudogobius (no rank).
/// NCBI TaxId: 2634600
/// </summary>
public abstract class unclassified_Pseudogobius : Pseudogobius, Iunclassified_Pseudogobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pseudogobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2634600;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pseudogobius";
}
