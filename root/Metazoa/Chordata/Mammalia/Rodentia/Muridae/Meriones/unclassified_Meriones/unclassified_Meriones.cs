using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Meriones;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Meriones.unclassified_Meriones;

/// <summary>
/// Abstract class for unclassified Meriones (no rank).
/// NCBI TaxId: 2629069
/// </summary>
public abstract class unclassified_Meriones : Meriones, Iunclassified_Meriones
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Meriones";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2629069;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Meriones";
}
