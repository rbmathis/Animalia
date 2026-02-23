using AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Astrochelys;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Astrochelys.unclassified_Astrochelys;

/// <summary>
/// Abstract class for unclassified Astrochelys (no rank).
/// NCBI TaxId: 2926748
/// </summary>
public abstract class unclassified_Astrochelys : Astrochelys, Iunclassified_Astrochelys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Astrochelys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2926748;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Astrochelys";
}
