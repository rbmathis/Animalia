using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae.Bathophilus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae.Bathophilus.unclassified_Bathophilus;

/// <summary>
/// Abstract class for unclassified Bathophilus (no rank).
/// NCBI TaxId: 2625112
/// </summary>
public abstract class unclassified_Bathophilus : Bathophilus, Iunclassified_Bathophilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bathophilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2625112;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bathophilus";
}
