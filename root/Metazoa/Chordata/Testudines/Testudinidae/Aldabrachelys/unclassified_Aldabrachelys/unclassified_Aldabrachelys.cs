using AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Aldabrachelys;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Aldabrachelys.unclassified_Aldabrachelys;

/// <summary>
/// Abstract class for unclassified Aldabrachelys (no rank).
/// NCBI TaxId: 2804317
/// </summary>
public abstract class unclassified_Aldabrachelys : Aldabrachelys, Iunclassified_Aldabrachelys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Aldabrachelys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2804317;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Aldabrachelys";
}
