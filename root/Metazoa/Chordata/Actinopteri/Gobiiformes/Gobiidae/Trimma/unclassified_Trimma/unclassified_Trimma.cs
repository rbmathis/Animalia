using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Trimma;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Trimma.unclassified_Trimma;

/// <summary>
/// Abstract class for unclassified Trimma (no rank).
/// NCBI TaxId: 2646373
/// </summary>
public abstract class unclassified_Trimma : Trimma, Iunclassified_Trimma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Trimma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646373;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Trimma";
}
