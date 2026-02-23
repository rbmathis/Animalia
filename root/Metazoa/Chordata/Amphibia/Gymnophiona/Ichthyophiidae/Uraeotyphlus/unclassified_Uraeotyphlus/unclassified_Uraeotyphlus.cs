using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Ichthyophiidae.Uraeotyphlus;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Ichthyophiidae.Uraeotyphlus.unclassified_Uraeotyphlus;

/// <summary>
/// Abstract class for unclassified Uraeotyphlus (no rank).
/// NCBI TaxId: 2647718
/// </summary>
public abstract class unclassified_Uraeotyphlus : Uraeotyphlus, Iunclassified_Uraeotyphlus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Uraeotyphlus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2647718;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Uraeotyphlus";
}
