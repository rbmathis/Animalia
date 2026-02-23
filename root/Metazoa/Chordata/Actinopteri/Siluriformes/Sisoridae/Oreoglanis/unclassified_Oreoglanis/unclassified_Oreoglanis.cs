using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae.Oreoglanis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae.Oreoglanis.unclassified_Oreoglanis;

/// <summary>
/// Abstract class for unclassified Oreoglanis (no rank).
/// NCBI TaxId: 2677464
/// </summary>
public abstract class unclassified_Oreoglanis : Oreoglanis, Iunclassified_Oreoglanis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Oreoglanis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2677464;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Oreoglanis";
}
