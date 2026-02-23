using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Microdesmus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Microdesmus.unclassified_Microdesmus;

/// <summary>
/// Abstract class for unclassified Microdesmus (no rank).
/// NCBI TaxId: 2629103
/// </summary>
public abstract class unclassified_Microdesmus : Microdesmus, Iunclassified_Microdesmus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Microdesmus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2629103;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Microdesmus";
}
