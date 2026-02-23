using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Pilosa;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Pilosa.unclassified_Pilosa;

/// <summary>
/// Abstract class for unclassified Pilosa (no rank).
/// NCBI TaxId: 948957
/// </summary>
public abstract class unclassified_Pilosa : Pilosa, Iunclassified_Pilosa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pilosa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 948957;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pilosa";
}
