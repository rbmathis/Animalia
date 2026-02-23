using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Phosichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Phosichthyidae.unclassified_Phosichthyidae;

/// <summary>
/// Abstract class for unclassified Phosichthyidae (no rank).
/// NCBI TaxId: 1781123
/// </summary>
public abstract class unclassified_Phosichthyidae : Phosichthyidae, Iunclassified_Phosichthyidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Phosichthyidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1781123;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Phosichthyidae";
}
