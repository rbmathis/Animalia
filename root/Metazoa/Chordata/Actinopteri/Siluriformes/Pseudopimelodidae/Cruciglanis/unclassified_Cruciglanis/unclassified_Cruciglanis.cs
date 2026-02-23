using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pseudopimelodidae.Cruciglanis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pseudopimelodidae.Cruciglanis.unclassified_Cruciglanis;

/// <summary>
/// Abstract class for unclassified Cruciglanis (no rank).
/// NCBI TaxId: 2646188
/// </summary>
public abstract class unclassified_Cruciglanis : Cruciglanis, Iunclassified_Cruciglanis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cruciglanis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646188;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cruciglanis";
}
