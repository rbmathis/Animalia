using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Chimaeriformes.Chimaeridae.Chimaera;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Chimaeriformes.Chimaeridae.Chimaera.unclassified_Chimaera;

/// <summary>
/// Abstract class for unclassified Chimaera (no rank).
/// NCBI TaxId: 2622825
/// </summary>
public abstract class unclassified_Chimaera : Chimaera, Iunclassified_Chimaera
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Chimaera";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2622825;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Chimaera";
}
