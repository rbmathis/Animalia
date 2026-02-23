using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.unclassified_Soricidae;

/// <summary>
/// Abstract class for unclassified Soricidae (no rank).
/// NCBI TaxId: 1158971
/// </summary>
public abstract class unclassified_Soricidae : Soricidae, Iunclassified_Soricidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Soricidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1158971;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Soricidae";
}
