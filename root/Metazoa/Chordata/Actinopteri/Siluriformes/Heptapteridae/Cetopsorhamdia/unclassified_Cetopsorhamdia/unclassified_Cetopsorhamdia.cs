using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Heptapteridae.Cetopsorhamdia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Heptapteridae.Cetopsorhamdia.unclassified_Cetopsorhamdia;

/// <summary>
/// Abstract class for unclassified Cetopsorhamdia (no rank).
/// NCBI TaxId: 2630910
/// </summary>
public abstract class unclassified_Cetopsorhamdia : Cetopsorhamdia, Iunclassified_Cetopsorhamdia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cetopsorhamdia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630910;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cetopsorhamdia";
}
