using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Somniosidae.Centroscymnus;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Somniosidae.Centroscymnus.unclassified_Centroscymnus;

/// <summary>
/// Abstract class for unclassified Centroscymnus (no rank).
/// NCBI TaxId: 2646560
/// </summary>
public abstract class unclassified_Centroscymnus : Centroscymnus, Iunclassified_Centroscymnus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Centroscymnus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646560;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Centroscymnus";
}
