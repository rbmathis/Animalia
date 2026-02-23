using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Didemnidae.Diplosoma;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Didemnidae.Diplosoma.unclassified_Diplosoma_in_tunicates;

/// <summary>
/// Abstract class for unclassified Diplosoma (in: tunicates) (no rank).
/// NCBI TaxId: 2688425
/// </summary>
public abstract class unclassified_Diplosoma_in_tunicates : Diplosoma, Iunclassified_Diplosoma_in_tunicates
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Diplosoma (in: tunicates)";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2688425;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Diplosoma_in_tunicates";
}
