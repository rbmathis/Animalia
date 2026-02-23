using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Diglossa;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Diglossa.unclassified_Diglossa;

/// <summary>
/// Abstract class for unclassified Diglossa (no rank).
/// NCBI TaxId: 3532537
/// </summary>
public abstract class unclassified_Diglossa : Diglossa, Iunclassified_Diglossa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Diglossa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3532537;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Diglossa";
}
