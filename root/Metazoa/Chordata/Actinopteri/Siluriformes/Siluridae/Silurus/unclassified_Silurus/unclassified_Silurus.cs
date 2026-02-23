using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Siluridae.Silurus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Siluridae.Silurus.unclassified_Silurus;

/// <summary>
/// Abstract class for unclassified Silurus (no rank).
/// NCBI TaxId: 2627382
/// </summary>
public abstract class unclassified_Silurus : Silurus, Iunclassified_Silurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Silurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2627382;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Silurus";
}
