using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae.Ariosoma;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae.Ariosoma.unclassified_Ariosoma;

/// <summary>
/// Abstract class for unclassified Ariosoma (no rank).
/// NCBI TaxId: 2638585
/// </summary>
public abstract class unclassified_Ariosoma : Ariosoma, Iunclassified_Ariosoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ariosoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2638585;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ariosoma";
}
