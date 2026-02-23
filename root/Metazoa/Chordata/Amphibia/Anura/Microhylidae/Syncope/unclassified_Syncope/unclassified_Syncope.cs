using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Syncope;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Syncope.unclassified_Syncope;

/// <summary>
/// Abstract class for unclassified Syncope (no rank).
/// NCBI TaxId: 2637772
/// </summary>
public abstract class unclassified_Syncope : Syncope, Iunclassified_Syncope
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Syncope";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2637772;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Syncope";
}
