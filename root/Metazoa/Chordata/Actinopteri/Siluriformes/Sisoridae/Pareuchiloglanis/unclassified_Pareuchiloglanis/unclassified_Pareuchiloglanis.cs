using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae.Pareuchiloglanis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae.Pareuchiloglanis.unclassified_Pareuchiloglanis;

/// <summary>
/// Abstract class for unclassified Pareuchiloglanis (no rank).
/// NCBI TaxId: 2641945
/// </summary>
public abstract class unclassified_Pareuchiloglanis : Pareuchiloglanis, Iunclassified_Pareuchiloglanis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pareuchiloglanis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2641945;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pareuchiloglanis";
}
