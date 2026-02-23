using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Gnatholepis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Gnatholepis.unclassified_Gnatholepis;

/// <summary>
/// Abstract class for unclassified Gnatholepis (no rank).
/// NCBI TaxId: 2640944
/// </summary>
public abstract class unclassified_Gnatholepis : Gnatholepis, Iunclassified_Gnatholepis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gnatholepis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640944;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gnatholepis";
}
