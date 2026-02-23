using AnimalKingdom.root.Metazoa.Chordata.Appendicularia.Copelata.Oikopleuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Appendicularia.Copelata.Oikopleuridae.unclassified_Oikopleuridae;

/// <summary>
/// Abstract class for unclassified Oikopleuridae (no rank).
/// NCBI TaxId: 2783105
/// </summary>
public abstract class unclassified_Oikopleuridae : Oikopleuridae, Iunclassified_Oikopleuridae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Oikopleuridae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2783105;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Oikopleuridae";
}
