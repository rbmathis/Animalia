using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Auchenipteridae.Ageneiosus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Auchenipteridae.Ageneiosus.unclassified_Ageneiosus;

/// <summary>
/// Abstract class for unclassified Ageneiosus (no rank).
/// NCBI TaxId: 3101804
/// </summary>
public abstract class unclassified_Ageneiosus : Ageneiosus, Iunclassified_Ageneiosus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ageneiosus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3101804;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ageneiosus";
}
