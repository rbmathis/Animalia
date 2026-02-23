using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Sylvisorex;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Sylvisorex.unclassified_Sylvisorex;

/// <summary>
/// Abstract class for unclassified Sylvisorex (no rank).
/// NCBI TaxId: 2639616
/// </summary>
public abstract class unclassified_Sylvisorex : Sylvisorex, Iunclassified_Sylvisorex
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sylvisorex";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2639616;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sylvisorex";
}
