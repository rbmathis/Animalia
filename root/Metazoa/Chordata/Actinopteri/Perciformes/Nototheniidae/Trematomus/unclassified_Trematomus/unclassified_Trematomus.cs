using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Nototheniidae.Trematomus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Nototheniidae.Trematomus.unclassified_Trematomus;

/// <summary>
/// Abstract class for unclassified Trematomus (no rank).
/// NCBI TaxId: 2641268
/// </summary>
public abstract class unclassified_Trematomus : Trematomus, Iunclassified_Trematomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Trematomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2641268;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Trematomus";
}
