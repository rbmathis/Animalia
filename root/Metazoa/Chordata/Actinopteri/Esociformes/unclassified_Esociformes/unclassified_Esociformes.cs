using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Esociformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Esociformes.unclassified_Esociformes;

/// <summary>
/// Abstract class for unclassified Esociformes (no rank).
/// NCBI TaxId: 891958
/// </summary>
public abstract class unclassified_Esociformes : Esociformes, Iunclassified_Esociformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Esociformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 891958;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Esociformes";
}
