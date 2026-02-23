using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Glyphoglossus;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Glyphoglossus.unclassified_Glyphoglossus;

/// <summary>
/// Abstract class for unclassified Glyphoglossus (no rank).
/// NCBI TaxId: 2609360
/// </summary>
public abstract class unclassified_Glyphoglossus : Glyphoglossus, Iunclassified_Glyphoglossus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Glyphoglossus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2609360;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Glyphoglossus";
}
