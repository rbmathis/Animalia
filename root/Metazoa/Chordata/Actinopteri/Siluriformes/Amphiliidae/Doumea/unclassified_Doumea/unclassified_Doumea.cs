using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Amphiliidae.Doumea;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Amphiliidae.Doumea.unclassified_Doumea;

/// <summary>
/// Abstract class for unclassified Doumea (no rank).
/// NCBI TaxId: 2685741
/// </summary>
public abstract class unclassified_Doumea : Doumea, Iunclassified_Doumea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Doumea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2685741;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Doumea";
}
