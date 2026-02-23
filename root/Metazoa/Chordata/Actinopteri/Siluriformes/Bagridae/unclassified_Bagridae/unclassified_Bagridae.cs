using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Bagridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Bagridae.unclassified_Bagridae;

/// <summary>
/// Abstract class for unclassified Bagridae (no rank).
/// NCBI TaxId: 3445696
/// </summary>
public abstract class unclassified_Bagridae : Bagridae, Iunclassified_Bagridae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bagridae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3445696;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bagridae";
}
