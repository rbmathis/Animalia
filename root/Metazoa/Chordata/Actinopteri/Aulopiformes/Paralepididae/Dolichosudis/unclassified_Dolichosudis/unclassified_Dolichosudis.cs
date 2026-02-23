using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Paralepididae.Dolichosudis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Paralepididae.Dolichosudis.unclassified_Dolichosudis;

/// <summary>
/// Abstract class for unclassified Dolichosudis (no rank).
/// NCBI TaxId: 2646768
/// </summary>
public abstract class unclassified_Dolichosudis : Dolichosudis, Iunclassified_Dolichosudis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Dolichosudis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646768;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Dolichosudis";
}
