using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae.Erethistoides;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae.Erethistoides.unclassified_Erethistoides;

/// <summary>
/// Abstract class for unclassified Erethistoides (no rank).
/// NCBI TaxId: 2619616
/// </summary>
public abstract class unclassified_Erethistoides : Erethistoides, Iunclassified_Erethistoides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Erethistoides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2619616;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Erethistoides";
}
