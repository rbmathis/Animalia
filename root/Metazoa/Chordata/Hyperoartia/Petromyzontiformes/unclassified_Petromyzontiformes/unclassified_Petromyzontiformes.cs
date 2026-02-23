using AnimalKingdom.root.Metazoa.Chordata.Hyperoartia.Petromyzontiformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Hyperoartia.Petromyzontiformes.unclassified_Petromyzontiformes;

/// <summary>
/// Abstract class for unclassified Petromyzontiformes (no rank).
/// NCBI TaxId: 794805
/// </summary>
public abstract class unclassified_Petromyzontiformes : Petromyzontiformes, Iunclassified_Petromyzontiformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Petromyzontiformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 794805;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Petromyzontiformes";
}
