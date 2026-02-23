using AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Alcedinidae.Alcedo;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Alcedinidae.Alcedo.unclassified_Alcedo;

/// <summary>
/// Abstract class for unclassified Alcedo (no rank).
/// NCBI TaxId: 2637222
/// </summary>
public abstract class unclassified_Alcedo : Alcedo, Iunclassified_Alcedo
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Alcedo";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2637222;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Alcedo";
}
