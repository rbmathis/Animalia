using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Crystallogobius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Crystallogobius.unclassified_Crystallogobius;

/// <summary>
/// Abstract class for unclassified Crystallogobius (no rank).
/// NCBI TaxId: 3429686
/// </summary>
public abstract class unclassified_Crystallogobius : Crystallogobius, Iunclassified_Crystallogobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Crystallogobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3429686;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Crystallogobius";
}
