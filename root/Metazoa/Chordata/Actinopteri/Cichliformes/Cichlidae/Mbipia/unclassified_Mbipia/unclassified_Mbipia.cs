using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Mbipia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Mbipia.unclassified_Mbipia;

/// <summary>
/// Abstract class for unclassified Mbipia (no rank).
/// NCBI TaxId: 2766860
/// </summary>
public abstract class unclassified_Mbipia : Mbipia, Iunclassified_Mbipia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Mbipia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2766860;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Mbipia";
}
