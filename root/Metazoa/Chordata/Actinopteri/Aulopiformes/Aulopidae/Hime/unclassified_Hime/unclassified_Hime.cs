using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Aulopidae.Hime;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Aulopidae.Hime.unclassified_Hime;

/// <summary>
/// Abstract class for unclassified Hime (no rank).
/// NCBI TaxId: 2646710
/// </summary>
public abstract class unclassified_Hime : Hime, Iunclassified_Hime
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hime";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646710;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hime";
}
