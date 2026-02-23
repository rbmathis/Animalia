using AnimalKingdom.root.Metazoa.Chordata.Appendicularia.Copelata.Oikopleuridae.Oikopleura;

namespace AnimalKingdom.root.Metazoa.Chordata.Appendicularia.Copelata.Oikopleuridae.Oikopleura.unclassified_Oikopleura;

/// <summary>
/// Abstract class for unclassified Oikopleura (no rank).
/// NCBI TaxId: 2624535
/// </summary>
public abstract class unclassified_Oikopleura : Oikopleura, Iunclassified_Oikopleura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Oikopleura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2624535;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Oikopleura";
}
