using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Trachichthyiformes.Trachichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Trachichthyiformes.Trachichthyidae.unclassified_Trachichthyidae;

/// <summary>
/// Abstract class for unclassified Trachichthyidae (no rank).
/// NCBI TaxId: 1605460
/// </summary>
public abstract class unclassified_Trachichthyidae : Trachichthyidae, Iunclassified_Trachichthyidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Trachichthyidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1605460;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Trachichthyidae";
}
