using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Echinosaura;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Echinosaura.unclassified_Echinosaura;

/// <summary>
/// Abstract class for unclassified Echinosaura (no rank).
/// NCBI TaxId: 2631729
/// </summary>
public abstract class unclassified_Echinosaura : Echinosaura, Iunclassified_Echinosaura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Echinosaura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2631729;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Echinosaura";
}
