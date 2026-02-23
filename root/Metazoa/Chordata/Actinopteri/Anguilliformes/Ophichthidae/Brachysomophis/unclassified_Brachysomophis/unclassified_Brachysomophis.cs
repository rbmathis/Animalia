using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae.Brachysomophis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae.Brachysomophis.unclassified_Brachysomophis;

/// <summary>
/// Abstract class for unclassified Brachysomophis (no rank).
/// NCBI TaxId: 3396998
/// </summary>
public abstract class unclassified_Brachysomophis : Brachysomophis, Iunclassified_Brachysomophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Brachysomophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3396998;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Brachysomophis";
}
