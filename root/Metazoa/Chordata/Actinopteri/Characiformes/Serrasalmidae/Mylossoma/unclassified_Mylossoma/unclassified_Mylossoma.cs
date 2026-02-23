using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Serrasalmidae.Mylossoma;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Serrasalmidae.Mylossoma.unclassified_Mylossoma;

/// <summary>
/// Abstract class for unclassified Mylossoma (no rank).
/// NCBI TaxId: 2633605
/// </summary>
public abstract class unclassified_Mylossoma : Mylossoma, Iunclassified_Mylossoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Mylossoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2633605;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Mylossoma";
}
