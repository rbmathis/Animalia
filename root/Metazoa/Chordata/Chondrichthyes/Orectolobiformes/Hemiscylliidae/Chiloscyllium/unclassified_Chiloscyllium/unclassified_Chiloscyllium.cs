using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Orectolobiformes.Hemiscylliidae.Chiloscyllium;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Orectolobiformes.Hemiscylliidae.Chiloscyllium.unclassified_Chiloscyllium;

/// <summary>
/// Abstract class for unclassified Chiloscyllium (no rank).
/// NCBI TaxId: 2599783
/// </summary>
public abstract class unclassified_Chiloscyllium : Chiloscyllium, Iunclassified_Chiloscyllium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Chiloscyllium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2599783;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Chiloscyllium";
}
