using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Certhiaxis;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Certhiaxis.unclassified_Certhiaxis;

/// <summary>
/// Abstract class for unclassified Certhiaxis (no rank).
/// NCBI TaxId: 2765008
/// </summary>
public abstract class unclassified_Certhiaxis : Certhiaxis, Iunclassified_Certhiaxis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Certhiaxis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2765008;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Certhiaxis";
}
