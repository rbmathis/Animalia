using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae.unclassified_Trichomycteridae;

/// <summary>
/// Abstract class for unclassified Trichomycteridae (no rank).
/// NCBI TaxId: 2563346
/// </summary>
public abstract class unclassified_Trichomycteridae : Trichomycteridae, Iunclassified_Trichomycteridae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Trichomycteridae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2563346;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Trichomycteridae";
}
