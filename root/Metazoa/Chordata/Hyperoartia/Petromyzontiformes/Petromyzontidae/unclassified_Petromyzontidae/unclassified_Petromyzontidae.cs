using AnimalKingdom.root.Metazoa.Chordata.Hyperoartia.Petromyzontiformes.Petromyzontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Hyperoartia.Petromyzontiformes.Petromyzontidae.unclassified_Petromyzontidae;

/// <summary>
/// Abstract class for unclassified Petromyzontidae (no rank).
/// NCBI TaxId: 70891
/// </summary>
public abstract class unclassified_Petromyzontidae : Petromyzontidae, Iunclassified_Petromyzontidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Petromyzontidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 70891;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Petromyzontidae";
}
