using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae.Rhinodoras;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae.Rhinodoras.unclassified_Rhinodoras;

/// <summary>
/// Abstract class for unclassified Rhinodoras (no rank).
/// NCBI TaxId: 2728231
/// </summary>
public abstract class unclassified_Rhinodoras : Rhinodoras, Iunclassified_Rhinodoras
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Rhinodoras";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2728231;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Rhinodoras";
}
