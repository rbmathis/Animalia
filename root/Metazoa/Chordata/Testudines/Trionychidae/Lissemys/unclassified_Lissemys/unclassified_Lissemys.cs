using AnimalKingdom.root.Metazoa.Chordata.Testudines.Trionychidae.Lissemys;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Trionychidae.Lissemys.unclassified_Lissemys;

/// <summary>
/// Abstract class for unclassified Lissemys (no rank).
/// NCBI TaxId: 2620174
/// </summary>
public abstract class unclassified_Lissemys : Lissemys, Iunclassified_Lissemys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lissemys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2620174;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lissemys";
}
