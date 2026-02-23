using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Setarchidae.Setarches;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Setarchidae.Setarches.unclassified_Setarches;

/// <summary>
/// Abstract class for unclassified Setarches (no rank).
/// NCBI TaxId: 2648171
/// </summary>
public abstract class unclassified_Setarches : Setarches, Iunclassified_Setarches
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Setarches";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2648171;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Setarches";
}
