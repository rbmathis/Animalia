using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Brachygobius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Brachygobius.unclassified_Brachygobius;

/// <summary>
/// Abstract class for unclassified Brachygobius (no rank).
/// NCBI TaxId: 2641947
/// </summary>
public abstract class unclassified_Brachygobius : Brachygobius, Iunclassified_Brachygobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Brachygobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2641947;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Brachygobius";
}
