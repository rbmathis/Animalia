using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pseudopimelodidae.Batrochoglanis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pseudopimelodidae.Batrochoglanis.unclassified_Batrochoglanis;

/// <summary>
/// Abstract class for unclassified Batrochoglanis (no rank).
/// NCBI TaxId: 2648862
/// </summary>
public abstract class unclassified_Batrochoglanis : Batrochoglanis, Iunclassified_Batrochoglanis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Batrochoglanis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2648862;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Batrochoglanis";
}
