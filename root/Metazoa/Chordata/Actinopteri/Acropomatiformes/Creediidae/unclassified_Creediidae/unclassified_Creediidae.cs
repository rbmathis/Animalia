using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Creediidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Creediidae.unclassified_Creediidae;

/// <summary>
/// Abstract class for unclassified Creediidae (no rank).
/// NCBI TaxId: 2861071
/// </summary>
public abstract class unclassified_Creediidae : Creediidae, Iunclassified_Creediidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Creediidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2861071;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Creediidae";
}
