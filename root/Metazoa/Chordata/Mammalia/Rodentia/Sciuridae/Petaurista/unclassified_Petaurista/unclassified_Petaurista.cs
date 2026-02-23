using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Petaurista;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Petaurista.unclassified_Petaurista;

/// <summary>
/// Abstract class for unclassified Petaurista (no rank).
/// NCBI TaxId: 3434621
/// </summary>
public abstract class unclassified_Petaurista : Petaurista, Iunclassified_Petaurista
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Petaurista";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3434621;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Petaurista";
}
