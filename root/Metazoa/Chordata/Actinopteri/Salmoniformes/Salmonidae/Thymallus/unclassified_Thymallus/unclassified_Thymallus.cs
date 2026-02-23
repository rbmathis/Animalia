using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Salmoniformes.Salmonidae.Thymallus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Salmoniformes.Salmonidae.Thymallus.unclassified_Thymallus;

/// <summary>
/// Abstract class for unclassified Thymallus (no rank).
/// NCBI TaxId: 2642186
/// </summary>
public abstract class unclassified_Thymallus : Thymallus, Iunclassified_Thymallus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Thymallus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2642186;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Thymallus";
}
