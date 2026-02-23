using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Caeciliidae.Caecilia;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Caeciliidae.Caecilia.unclassified_Caecilia;

/// <summary>
/// Abstract class for unclassified Caecilia (no rank).
/// NCBI TaxId: 2621455
/// </summary>
public abstract class unclassified_Caecilia : Caecilia, Iunclassified_Caecilia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Caecilia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621455;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Caecilia";
}
