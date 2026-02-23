using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Achiridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Achiridae.unclassified_Achiridae;

/// <summary>
/// Abstract class for unclassified Achiridae (no rank).
/// NCBI TaxId: 1182215
/// </summary>
public abstract class unclassified_Achiridae : Achiridae, Iunclassified_Achiridae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Achiridae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1182215;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Achiridae";
}
