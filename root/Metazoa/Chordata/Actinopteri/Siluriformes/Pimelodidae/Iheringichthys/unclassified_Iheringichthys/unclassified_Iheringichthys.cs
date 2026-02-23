using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae.Iheringichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae.Iheringichthys.unclassified_Iheringichthys;

/// <summary>
/// Abstract class for unclassified Iheringichthys (no rank).
/// NCBI TaxId: 2734639
/// </summary>
public abstract class unclassified_Iheringichthys : Iheringichthys, Iunclassified_Iheringichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Iheringichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2734639;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Iheringichthys";
}
