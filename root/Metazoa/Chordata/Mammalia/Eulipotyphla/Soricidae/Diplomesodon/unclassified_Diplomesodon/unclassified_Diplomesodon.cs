using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Diplomesodon;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Diplomesodon.unclassified_Diplomesodon;

/// <summary>
/// Abstract class for unclassified Diplomesodon (no rank).
/// NCBI TaxId: 3051454
/// </summary>
public abstract class unclassified_Diplomesodon : Diplomesodon, Iunclassified_Diplomesodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Diplomesodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3051454;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Diplomesodon";
}
