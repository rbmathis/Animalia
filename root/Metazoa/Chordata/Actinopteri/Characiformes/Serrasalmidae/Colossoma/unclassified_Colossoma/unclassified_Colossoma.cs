using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Serrasalmidae.Colossoma;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Serrasalmidae.Colossoma.unclassified_Colossoma;

/// <summary>
/// Abstract class for unclassified Colossoma (no rank).
/// NCBI TaxId: 2648143
/// </summary>
public abstract class unclassified_Colossoma : Colossoma, Iunclassified_Colossoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Colossoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2648143;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Colossoma";
}
