using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae.Megalodoras;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae.Megalodoras.unclassified_Megalodoras;

/// <summary>
/// Abstract class for unclassified Megalodoras (no rank).
/// NCBI TaxId: 2728225
/// </summary>
public abstract class unclassified_Megalodoras : Megalodoras, Iunclassified_Megalodoras
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Megalodoras";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2728225;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Megalodoras";
}
