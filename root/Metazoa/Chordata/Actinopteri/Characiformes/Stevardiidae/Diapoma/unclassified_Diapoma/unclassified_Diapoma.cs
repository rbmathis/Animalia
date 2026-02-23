using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Diapoma;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Diapoma.unclassified_Diapoma;

/// <summary>
/// Abstract class for unclassified Diapoma (no rank).
/// NCBI TaxId: 2608179
/// </summary>
public abstract class unclassified_Diapoma : Diapoma, Iunclassified_Diapoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Diapoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2608179;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Diapoma";
}
