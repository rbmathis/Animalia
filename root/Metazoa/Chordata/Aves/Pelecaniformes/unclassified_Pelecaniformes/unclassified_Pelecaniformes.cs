using AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.unclassified_Pelecaniformes;

/// <summary>
/// Abstract class for unclassified Pelecaniformes (no rank).
/// NCBI TaxId: 772020
/// </summary>
public abstract class unclassified_Pelecaniformes : Pelecaniformes, Iunclassified_Pelecaniformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pelecaniformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 772020;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pelecaniformes";
}
