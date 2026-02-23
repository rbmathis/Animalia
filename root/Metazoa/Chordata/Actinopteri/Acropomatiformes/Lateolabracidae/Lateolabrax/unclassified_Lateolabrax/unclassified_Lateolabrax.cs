using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Lateolabracidae.Lateolabrax;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Lateolabracidae.Lateolabrax.unclassified_Lateolabrax;

/// <summary>
/// Abstract class for unclassified Lateolabrax (no rank).
/// NCBI TaxId: 2637278
/// </summary>
public abstract class unclassified_Lateolabrax : Lateolabrax, Iunclassified_Lateolabrax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lateolabrax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2637278;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lateolabrax";
}
