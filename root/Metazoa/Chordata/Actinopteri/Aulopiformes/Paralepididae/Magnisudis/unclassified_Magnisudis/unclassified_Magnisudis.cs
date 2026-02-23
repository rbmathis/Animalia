using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Paralepididae.Magnisudis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Paralepididae.Magnisudis.unclassified_Magnisudis;

/// <summary>
/// Abstract class for unclassified Magnisudis (no rank).
/// NCBI TaxId: 2648823
/// </summary>
public abstract class unclassified_Magnisudis : Magnisudis, Iunclassified_Magnisudis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Magnisudis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2648823;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Magnisudis";
}
