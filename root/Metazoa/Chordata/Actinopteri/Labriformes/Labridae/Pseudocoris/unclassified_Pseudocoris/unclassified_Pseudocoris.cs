using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Pseudocoris;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Pseudocoris.unclassified_Pseudocoris;

/// <summary>
/// Abstract class for unclassified Pseudocoris (no rank).
/// NCBI TaxId: 2639392
/// </summary>
public abstract class unclassified_Pseudocoris : Pseudocoris, Iunclassified_Pseudocoris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pseudocoris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2639392;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pseudocoris";
}
