using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae.Pterodoras;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae.Pterodoras.unclassified_Pterodoras;

/// <summary>
/// Abstract class for unclassified Pterodoras (no rank).
/// NCBI TaxId: 2639192
/// </summary>
public abstract class unclassified_Pterodoras : Pterodoras, Iunclassified_Pterodoras
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pterodoras";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2639192;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pterodoras";
}
