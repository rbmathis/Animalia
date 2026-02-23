using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Calomyscidae.Calomyscus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Calomyscidae.Calomyscus.unclassified_Calomyscus;

/// <summary>
/// Abstract class for unclassified Calomyscus (no rank).
/// NCBI TaxId: 2627105
/// </summary>
public abstract class unclassified_Calomyscus : Calomyscus, Iunclassified_Calomyscus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Calomyscus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2627105;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Calomyscus";
}
