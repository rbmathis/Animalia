using AnimalKingdom.root.Metazoa.Chordata.Thaliacea.Salpida.Salpidae.Thalia;

namespace AnimalKingdom.root.Metazoa.Chordata.Thaliacea.Salpida.Salpidae.Thalia.unclassified_Thalia_in_tunicates;

/// <summary>
/// Abstract class for unclassified Thalia (in: tunicates) (no rank).
/// NCBI TaxId: 2688991
/// </summary>
public abstract class unclassified_Thalia_in_tunicates : Thalia, Iunclassified_Thalia_in_tunicates
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Thalia (in: tunicates)";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2688991;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Thalia_in_tunicates";
}
