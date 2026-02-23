using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Synbranchiformes.Synbranchidae.Monopterus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Synbranchiformes.Synbranchidae.Monopterus.unclassified_Monopterus;

/// <summary>
/// Abstract class for unclassified Monopterus (no rank).
/// NCBI TaxId: 2685838
/// </summary>
public abstract class unclassified_Monopterus : Monopterus, Iunclassified_Monopterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Monopterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2685838;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Monopterus";
}
