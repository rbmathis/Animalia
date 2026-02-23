using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Elopiformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Elopiformes.unclassified_Elopiformes;

/// <summary>
/// Abstract class for unclassified Elopiformes (no rank).
/// NCBI TaxId: 725927
/// </summary>
public abstract class unclassified_Elopiformes : Elopiformes, Iunclassified_Elopiformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Elopiformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 725927;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Elopiformes";
}
