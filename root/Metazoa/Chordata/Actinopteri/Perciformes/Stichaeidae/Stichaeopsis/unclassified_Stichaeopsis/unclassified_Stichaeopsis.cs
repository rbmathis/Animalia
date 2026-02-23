using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae.Stichaeopsis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae.Stichaeopsis.unclassified_Stichaeopsis;

/// <summary>
/// Abstract class for unclassified Stichaeopsis (no rank).
/// NCBI TaxId: 2629125
/// </summary>
public abstract class unclassified_Stichaeopsis : Stichaeopsis, Iunclassified_Stichaeopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Stichaeopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2629125;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Stichaeopsis";
}
