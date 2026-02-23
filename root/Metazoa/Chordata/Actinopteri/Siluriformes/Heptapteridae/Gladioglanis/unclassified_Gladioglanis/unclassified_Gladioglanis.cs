using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Heptapteridae.Gladioglanis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Heptapteridae.Gladioglanis.unclassified_Gladioglanis;

/// <summary>
/// Abstract class for unclassified Gladioglanis (no rank).
/// NCBI TaxId: 2829549
/// </summary>
public abstract class unclassified_Gladioglanis : Gladioglanis, Iunclassified_Gladioglanis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gladioglanis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2829549;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gladioglanis";
}
