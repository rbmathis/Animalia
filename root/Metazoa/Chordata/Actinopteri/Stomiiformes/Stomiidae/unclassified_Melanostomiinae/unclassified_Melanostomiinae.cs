using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae.unclassified_Melanostomiinae;

/// <summary>
/// Abstract class for unclassified Melanostomiinae (no rank).
/// NCBI TaxId: 2581826
/// </summary>
public abstract class unclassified_Melanostomiinae : Stomiidae, Iunclassified_Melanostomiinae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Melanostomiinae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2581826;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Melanostomiinae";
}
