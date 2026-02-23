using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Typhlonectidae.Typhlonectes;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Typhlonectidae.Typhlonectes.unclassified_Typhlonectes;

/// <summary>
/// Abstract class for unclassified Typhlonectes (no rank).
/// NCBI TaxId: 2637049
/// </summary>
public abstract class unclassified_Typhlonectes : Typhlonectes, Iunclassified_Typhlonectes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Typhlonectes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2637049;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Typhlonectes";
}
