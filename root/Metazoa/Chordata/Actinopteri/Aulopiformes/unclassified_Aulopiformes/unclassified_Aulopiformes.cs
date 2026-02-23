using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.unclassified_Aulopiformes;

/// <summary>
/// Abstract class for unclassified Aulopiformes (no rank).
/// NCBI TaxId: 725767
/// </summary>
public abstract class unclassified_Aulopiformes : Aulopiformes, Iunclassified_Aulopiformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Aulopiformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 725767;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Aulopiformes";
}
