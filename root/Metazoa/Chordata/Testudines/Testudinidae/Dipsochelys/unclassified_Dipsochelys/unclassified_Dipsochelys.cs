using AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Dipsochelys;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Dipsochelys.unclassified_Dipsochelys;

/// <summary>
/// Abstract class for unclassified Dipsochelys (no rank).
/// NCBI TaxId: 2630776
/// </summary>
public abstract class unclassified_Dipsochelys : Dipsochelys, Iunclassified_Dipsochelys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Dipsochelys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630776;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Dipsochelys";
}
