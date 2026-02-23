using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.unclassified_Gymnophiona;

/// <summary>
/// Abstract class for unclassified Gymnophiona (no rank).
/// NCBI TaxId: 941925
/// </summary>
public abstract class unclassified_Gymnophiona : Gymnophiona, Iunclassified_Gymnophiona
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gymnophiona";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 941925;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gymnophiona";
}
