using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Elacatinus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Elacatinus.unclassified_Elacatinus;

/// <summary>
/// Abstract class for unclassified Elacatinus (no rank).
/// NCBI TaxId: 2648521
/// </summary>
public abstract class unclassified_Elacatinus : Elacatinus, Iunclassified_Elacatinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Elacatinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2648521;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Elacatinus";
}
