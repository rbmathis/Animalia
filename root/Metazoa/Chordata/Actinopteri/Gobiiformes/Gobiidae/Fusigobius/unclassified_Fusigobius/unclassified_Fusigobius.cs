using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Fusigobius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Fusigobius.unclassified_Fusigobius;

/// <summary>
/// Abstract class for unclassified Fusigobius (no rank).
/// NCBI TaxId: 2642483
/// </summary>
public abstract class unclassified_Fusigobius : Fusigobius, Iunclassified_Fusigobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Fusigobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2642483;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Fusigobius";
}
