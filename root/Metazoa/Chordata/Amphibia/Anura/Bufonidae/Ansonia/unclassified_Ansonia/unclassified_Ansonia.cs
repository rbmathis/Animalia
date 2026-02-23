using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Ansonia;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Ansonia.unclassified_Ansonia;

/// <summary>
/// Abstract class for unclassified Ansonia (no rank).
/// NCBI TaxId: 2633652
/// </summary>
public abstract class unclassified_Ansonia : Ansonia, Iunclassified_Ansonia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ansonia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2633652;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ansonia";
}
