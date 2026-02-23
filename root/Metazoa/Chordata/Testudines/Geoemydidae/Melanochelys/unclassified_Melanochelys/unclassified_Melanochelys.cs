using AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Melanochelys;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Melanochelys.unclassified_Melanochelys;

/// <summary>
/// Abstract class for unclassified Melanochelys (no rank).
/// NCBI TaxId: 2619204
/// </summary>
public abstract class unclassified_Melanochelys : Melanochelys, Iunclassified_Melanochelys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Melanochelys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2619204;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Melanochelys";
}
