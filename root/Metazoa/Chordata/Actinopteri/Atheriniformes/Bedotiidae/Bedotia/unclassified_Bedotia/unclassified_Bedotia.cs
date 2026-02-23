using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Bedotiidae.Bedotia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Bedotiidae.Bedotia.unclassified_Bedotia;

/// <summary>
/// Abstract class for unclassified Bedotia (no rank).
/// NCBI TaxId: 2646895
/// </summary>
public abstract class unclassified_Bedotia : Bedotia, Iunclassified_Bedotia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bedotia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646895;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bedotia";
}
