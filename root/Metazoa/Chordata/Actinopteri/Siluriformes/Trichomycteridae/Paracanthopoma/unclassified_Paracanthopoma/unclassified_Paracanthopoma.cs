using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae.Paracanthopoma;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae.Paracanthopoma.unclassified_Paracanthopoma;

/// <summary>
/// Abstract class for unclassified Paracanthopoma (no rank).
/// NCBI TaxId: 2640247
/// </summary>
public abstract class unclassified_Paracanthopoma : Paracanthopoma, Iunclassified_Paracanthopoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Paracanthopoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640247;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Paracanthopoma";
}
