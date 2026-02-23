using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Synodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Synodontidae.unclassified_Synodontinae;

/// <summary>
/// Abstract class for unclassified Synodontinae (no rank).
/// NCBI TaxId: 1182131
/// </summary>
public abstract class unclassified_Synodontinae : Synodontidae, Iunclassified_Synodontinae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Synodontinae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1182131;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Synodontinae";
}
