using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Chimaeriformes.Chimaeridae.Hydrolagus;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Chimaeriformes.Chimaeridae.Hydrolagus.unclassified_Hydrolagus;

/// <summary>
/// Abstract class for unclassified Hydrolagus (no rank).
/// NCBI TaxId: 2646897
/// </summary>
public abstract class unclassified_Hydrolagus : Hydrolagus, Iunclassified_Hydrolagus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hydrolagus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646897;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hydrolagus";
}
