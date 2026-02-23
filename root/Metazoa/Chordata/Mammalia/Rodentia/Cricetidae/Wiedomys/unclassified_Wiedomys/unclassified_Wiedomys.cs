using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Wiedomys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Wiedomys.unclassified_Wiedomys;

/// <summary>
/// Abstract class for unclassified Wiedomys (no rank).
/// NCBI TaxId: 2617868
/// </summary>
public abstract class unclassified_Wiedomys : Wiedomys, Iunclassified_Wiedomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Wiedomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2617868;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Wiedomys";
}
