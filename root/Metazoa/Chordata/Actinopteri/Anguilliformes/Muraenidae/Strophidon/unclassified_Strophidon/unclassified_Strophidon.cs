using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Muraenidae.Strophidon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Muraenidae.Strophidon.unclassified_Strophidon;

/// <summary>
/// Abstract class for unclassified Strophidon (no rank).
/// NCBI TaxId: 2636814
/// </summary>
public abstract class unclassified_Strophidon : Strophidon, Iunclassified_Strophidon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Strophidon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2636814;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Strophidon";
}
