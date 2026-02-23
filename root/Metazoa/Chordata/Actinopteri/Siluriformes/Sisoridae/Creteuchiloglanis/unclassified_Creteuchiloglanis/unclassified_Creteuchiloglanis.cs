using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae.Creteuchiloglanis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae.Creteuchiloglanis.unclassified_Creteuchiloglanis;

/// <summary>
/// Abstract class for unclassified Creteuchiloglanis (no rank).
/// NCBI TaxId: 2984446
/// </summary>
public abstract class unclassified_Creteuchiloglanis : Creteuchiloglanis, Iunclassified_Creteuchiloglanis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Creteuchiloglanis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2984446;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Creteuchiloglanis";
}
