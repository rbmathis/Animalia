using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Clavelinidae.Distaplia;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Clavelinidae.Distaplia.unclassified_Distaplia;

/// <summary>
/// Abstract class for unclassified Distaplia (no rank).
/// NCBI TaxId: 2633128
/// </summary>
public abstract class unclassified_Distaplia : Distaplia, Iunclassified_Distaplia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Distaplia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2633128;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Distaplia";
}
