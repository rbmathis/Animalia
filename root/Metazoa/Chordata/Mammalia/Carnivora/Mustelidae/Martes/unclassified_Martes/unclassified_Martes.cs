using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae.Martes;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae.Martes.unclassified_Martes;

/// <summary>
/// Abstract class for unclassified Martes (no rank).
/// NCBI TaxId: 1628726
/// </summary>
public abstract class unclassified_Martes : Martes, Iunclassified_Martes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Martes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1628726;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Martes";
}
