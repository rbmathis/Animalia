using AnimalKingdom.root.Metazoa.Chordata.Aves.Tinamiformes.Tinamidae.Crypturellus;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Tinamiformes.Tinamidae.Crypturellus.unclassified_Crypturellus;

/// <summary>
/// Abstract class for unclassified Crypturellus (no rank).
/// NCBI TaxId: 2637307
/// </summary>
public abstract class unclassified_Crypturellus : Crypturellus, Iunclassified_Crypturellus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Crypturellus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2637307;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Crypturellus";
}
