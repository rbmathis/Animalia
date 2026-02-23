using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Phacellodomus;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Phacellodomus.unclassified_Phacellodomus;

/// <summary>
/// Abstract class for unclassified Phacellodomus (no rank).
/// NCBI TaxId: 2641269
/// </summary>
public abstract class unclassified_Phacellodomus : Phacellodomus, Iunclassified_Phacellodomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Phacellodomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2641269;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Phacellodomus";
}
