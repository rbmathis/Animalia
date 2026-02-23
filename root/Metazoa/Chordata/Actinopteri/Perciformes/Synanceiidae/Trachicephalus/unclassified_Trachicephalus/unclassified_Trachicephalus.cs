using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Synanceiidae.Trachicephalus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Synanceiidae.Trachicephalus.unclassified_Trachicephalus;

/// <summary>
/// Abstract class for unclassified Trachicephalus (no rank).
/// NCBI TaxId: 3051019
/// </summary>
public abstract class unclassified_Trachicephalus : Trachicephalus, Iunclassified_Trachicephalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Trachicephalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3051019;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Trachicephalus";
}
