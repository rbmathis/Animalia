using AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Trachemys;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Trachemys.unclassified_Trachemys;

/// <summary>
/// Abstract class for unclassified Trachemys (no rank).
/// NCBI TaxId: 2644994
/// </summary>
public abstract class unclassified_Trachemys : Trachemys, Iunclassified_Trachemys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Trachemys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2644994;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Trachemys";
}
