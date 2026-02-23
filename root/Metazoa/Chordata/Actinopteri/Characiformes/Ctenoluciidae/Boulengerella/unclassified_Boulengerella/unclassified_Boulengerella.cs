using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Ctenoluciidae.Boulengerella;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Ctenoluciidae.Boulengerella.unclassified_Boulengerella;

/// <summary>
/// Abstract class for unclassified Boulengerella (no rank).
/// NCBI TaxId: 2637749
/// </summary>
public abstract class unclassified_Boulengerella : Boulengerella, Iunclassified_Boulengerella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Boulengerella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2637749;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Boulengerella";
}
