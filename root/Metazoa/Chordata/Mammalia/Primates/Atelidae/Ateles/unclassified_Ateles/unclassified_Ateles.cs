using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Atelidae.Ateles;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Atelidae.Ateles.unclassified_Ateles;

/// <summary>
/// Abstract class for unclassified Ateles (no rank).
/// NCBI TaxId: 120432
/// </summary>
public abstract class unclassified_Ateles : Ateles, Iunclassified_Ateles
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ateles";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 120432;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ateles";
}
