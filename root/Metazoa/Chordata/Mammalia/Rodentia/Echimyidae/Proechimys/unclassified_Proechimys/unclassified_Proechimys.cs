using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Echimyidae.Proechimys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Echimyidae.Proechimys.unclassified_Proechimys;

/// <summary>
/// Abstract class for unclassified Proechimys (no rank).
/// NCBI TaxId: 2645178
/// </summary>
public abstract class unclassified_Proechimys : Proechimys, Iunclassified_Proechimys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Proechimys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2645178;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Proechimys";
}
