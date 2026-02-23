using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Geomyidae.Geomys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Geomyidae.Geomys.unclassified_Geomys;

/// <summary>
/// Abstract class for unclassified Geomys (no rank).
/// NCBI TaxId: 3435575
/// </summary>
public abstract class unclassified_Geomys : Geomys, Iunclassified_Geomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Geomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3435575;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Geomys";
}
