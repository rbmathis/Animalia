using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Heliactin;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Heliactin.unclassified_Heliactin;

/// <summary>
/// Abstract class for unclassified Heliactin (no rank).
/// NCBI TaxId: 3242239
/// </summary>
public abstract class unclassified_Heliactin : Heliactin, Iunclassified_Heliactin
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Heliactin";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3242239;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Heliactin";
}
