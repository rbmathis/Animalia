using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae.Parastegophilus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae.Parastegophilus.unclassified_Parastegophilus;

/// <summary>
/// Abstract class for unclassified Parastegophilus (no rank).
/// NCBI TaxId: 2635741
/// </summary>
public abstract class unclassified_Parastegophilus : Parastegophilus, Iunclassified_Parastegophilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Parastegophilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2635741;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Parastegophilus";
}
