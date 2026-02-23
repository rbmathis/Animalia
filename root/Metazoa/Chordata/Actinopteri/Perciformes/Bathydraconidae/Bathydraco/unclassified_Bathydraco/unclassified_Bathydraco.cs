using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Bathydraconidae.Bathydraco;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Bathydraconidae.Bathydraco.unclassified_Bathydraco;

/// <summary>
/// Abstract class for unclassified Bathydraco (no rank).
/// NCBI TaxId: 2631673
/// </summary>
public abstract class unclassified_Bathydraco : Bathydraco, Iunclassified_Bathydraco
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bathydraco";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2631673;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bathydraco";
}
