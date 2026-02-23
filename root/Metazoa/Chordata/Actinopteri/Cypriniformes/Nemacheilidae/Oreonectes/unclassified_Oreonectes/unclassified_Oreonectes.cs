using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Oreonectes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Oreonectes.unclassified_Oreonectes;

/// <summary>
/// Abstract class for unclassified Oreonectes (no rank).
/// NCBI TaxId: 2624515
/// </summary>
public abstract class unclassified_Oreonectes : Oreonectes, Iunclassified_Oreonectes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Oreonectes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2624515;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Oreonectes";
}
