using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.unclassified_Beryciformes;

/// <summary>
/// Abstract class for unclassified Beryciformes (no rank).
/// NCBI TaxId: 723959
/// </summary>
public abstract class unclassified_Beryciformes : Beryciformes, Iunclassified_Beryciformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Beryciformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 723959;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Beryciformes";
}
