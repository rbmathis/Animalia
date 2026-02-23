using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae.unclassified_Stomiidae;

/// <summary>
/// Abstract class for unclassified Stomiidae (no rank).
/// NCBI TaxId: 2582064
/// </summary>
public abstract class unclassified_Stomiidae : Stomiidae, Iunclassified_Stomiidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Stomiidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2582064;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Stomiidae";
}
