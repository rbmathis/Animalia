using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Nesomyidae.Saccostomus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Nesomyidae.Saccostomus.unclassified_Saccostomus;

/// <summary>
/// Abstract class for unclassified Saccostomus (no rank).
/// NCBI TaxId: 247997
/// </summary>
public abstract class unclassified_Saccostomus : Saccostomus, Iunclassified_Saccostomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Saccostomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 247997;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Saccostomus";
}
