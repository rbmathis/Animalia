using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Chimaeriformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Chimaeriformes.unclassified_Chimaeriformes;

/// <summary>
/// Abstract class for unclassified Chimaeriformes (no rank).
/// NCBI TaxId: 732567
/// </summary>
public abstract class unclassified_Chimaeriformes : Chimaeriformes, Iunclassified_Chimaeriformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Chimaeriformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 732567;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Chimaeriformes";
}
