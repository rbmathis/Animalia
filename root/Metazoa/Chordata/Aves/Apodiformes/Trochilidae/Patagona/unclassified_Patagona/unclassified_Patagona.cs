using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Patagona;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Patagona.unclassified_Patagona;

/// <summary>
/// Abstract class for unclassified Patagona (no rank).
/// NCBI TaxId: 3142391
/// </summary>
public abstract class unclassified_Patagona : Patagona, Iunclassified_Patagona
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Patagona";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3142391;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Patagona";
}
