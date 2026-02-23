using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Dactylopteridae.Dactyloptena;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Dactylopteridae.Dactyloptena.unclassified_Dactyloptena;

/// <summary>
/// Abstract class for unclassified Dactyloptena (no rank).
/// NCBI TaxId: 2990045
/// </summary>
public abstract class unclassified_Dactyloptena : Dactyloptena, Iunclassified_Dactyloptena
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Dactyloptena";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2990045;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Dactyloptena";
}
