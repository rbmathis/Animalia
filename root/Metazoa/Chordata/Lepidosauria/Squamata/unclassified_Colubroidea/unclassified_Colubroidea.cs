using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.unclassified_Colubroidea;

/// <summary>
/// Abstract class for unclassified Colubroidea (no rank).
/// NCBI TaxId: 2056565
/// </summary>
public abstract class unclassified_Colubroidea : Squamata, Iunclassified_Colubroidea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Colubroidea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2056565;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Colubroidea";
}
