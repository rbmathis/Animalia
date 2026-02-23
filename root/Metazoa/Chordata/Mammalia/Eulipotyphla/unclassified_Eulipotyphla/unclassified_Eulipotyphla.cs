using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.unclassified_Eulipotyphla;

/// <summary>
/// Abstract class for unclassified Eulipotyphla (no rank).
/// NCBI TaxId: 727877
/// </summary>
public abstract class unclassified_Eulipotyphla : Eulipotyphla, Iunclassified_Eulipotyphla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Eulipotyphla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 727877;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Eulipotyphla";
}
