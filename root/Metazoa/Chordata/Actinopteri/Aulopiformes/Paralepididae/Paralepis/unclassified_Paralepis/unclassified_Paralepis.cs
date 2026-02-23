using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Paralepididae.Paralepis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Paralepididae.Paralepis.unclassified_Paralepis;

/// <summary>
/// Abstract class for unclassified Paralepis (no rank).
/// NCBI TaxId: 2768196
/// </summary>
public abstract class unclassified_Paralepis : Paralepis, Iunclassified_Paralepis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Paralepis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2768196;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Paralepis";
}
