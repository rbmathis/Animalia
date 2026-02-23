using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Nemichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Nemichthyidae.unclassified_Nemichthyidae;

/// <summary>
/// Abstract class for unclassified Nemichthyidae (no rank).
/// NCBI TaxId: 1442071
/// </summary>
public abstract class unclassified_Nemichthyidae : Nemichthyidae, Iunclassified_Nemichthyidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Nemichthyidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1442071;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Nemichthyidae";
}
