using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Achiridae.Trinectes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Achiridae.Trinectes.unclassified_Trinectes;

/// <summary>
/// Abstract class for unclassified Trinectes (no rank).
/// NCBI TaxId: 3237095
/// </summary>
public abstract class unclassified_Trinectes : Trinectes, Iunclassified_Trinectes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Trinectes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3237095;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Trinectes";
}
