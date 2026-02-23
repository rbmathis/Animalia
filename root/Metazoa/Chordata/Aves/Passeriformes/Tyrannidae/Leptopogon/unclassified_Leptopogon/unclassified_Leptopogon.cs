using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Leptopogon;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Leptopogon.unclassified_Leptopogon;

/// <summary>
/// Abstract class for unclassified Leptopogon (no rank).
/// NCBI TaxId: 2632392
/// </summary>
public abstract class unclassified_Leptopogon : Leptopogon, Iunclassified_Leptopogon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Leptopogon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2632392;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Leptopogon";
}
