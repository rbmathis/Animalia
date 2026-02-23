using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Tubulidentata.Orycteropodidae.Orycteropus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Tubulidentata.Orycteropodidae.Orycteropus.unclassified_Orycteropus;

/// <summary>
/// Abstract class for unclassified Orycteropus (no rank).
/// NCBI TaxId: 2968395
/// </summary>
public abstract class unclassified_Orycteropus : Orycteropus, Iunclassified_Orycteropus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Orycteropus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2968395;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Orycteropus";
}
