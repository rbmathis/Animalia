using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anthiadidae.Luzonichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anthiadidae.Luzonichthys.unclassified_Luzonichthys;

/// <summary>
/// Abstract class for unclassified Luzonichthys (no rank).
/// NCBI TaxId: 2625673
/// </summary>
public abstract class unclassified_Luzonichthys : Luzonichthys, Iunclassified_Luzonichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Luzonichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2625673;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Luzonichthys";
}
