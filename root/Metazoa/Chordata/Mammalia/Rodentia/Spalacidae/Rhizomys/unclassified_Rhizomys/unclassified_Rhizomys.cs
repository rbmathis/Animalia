using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Spalacidae.Rhizomys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Spalacidae.Rhizomys.unclassified_Rhizomys;

/// <summary>
/// Abstract class for unclassified Rhizomys (no rank).
/// NCBI TaxId: 2617859
/// </summary>
public abstract class unclassified_Rhizomys : Rhizomys, Iunclassified_Rhizomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Rhizomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2617859;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Rhizomys";
}
