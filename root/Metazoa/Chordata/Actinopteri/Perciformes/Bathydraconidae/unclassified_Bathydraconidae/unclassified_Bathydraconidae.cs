using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Bathydraconidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Bathydraconidae.unclassified_Bathydraconidae;

/// <summary>
/// Abstract class for unclassified Bathydraconidae (no rank).
/// NCBI TaxId: 947863
/// </summary>
public abstract class unclassified_Bathydraconidae : Bathydraconidae, Iunclassified_Bathydraconidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bathydraconidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 947863;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bathydraconidae";
}
