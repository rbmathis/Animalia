using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Gasteropelecidae.Thoracocharax;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Gasteropelecidae.Thoracocharax.unclassified_Thoracocharax;

/// <summary>
/// Abstract class for unclassified Thoracocharax (no rank).
/// NCBI TaxId: 2626633
/// </summary>
public abstract class unclassified_Thoracocharax : Thoracocharax, Iunclassified_Thoracocharax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Thoracocharax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626633;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Thoracocharax";
}
