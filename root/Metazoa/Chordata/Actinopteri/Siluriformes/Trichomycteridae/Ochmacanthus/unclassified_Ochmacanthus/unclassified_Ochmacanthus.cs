using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae.Ochmacanthus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae.Ochmacanthus.unclassified_Ochmacanthus;

/// <summary>
/// Abstract class for unclassified Ochmacanthus (no rank).
/// NCBI TaxId: 2632275
/// </summary>
public abstract class unclassified_Ochmacanthus : Ochmacanthus, Iunclassified_Ochmacanthus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ochmacanthus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2632275;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ochmacanthus";
}
