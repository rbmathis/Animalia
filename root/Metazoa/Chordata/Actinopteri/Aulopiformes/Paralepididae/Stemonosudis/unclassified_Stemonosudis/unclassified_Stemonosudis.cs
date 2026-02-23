using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Paralepididae.Stemonosudis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Paralepididae.Stemonosudis.unclassified_Stemonosudis;

/// <summary>
/// Abstract class for unclassified Stemonosudis (no rank).
/// NCBI TaxId: 3083371
/// </summary>
public abstract class unclassified_Stemonosudis : Stemonosudis, Iunclassified_Stemonosudis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Stemonosudis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3083371;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Stemonosudis";
}
