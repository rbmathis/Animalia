using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Dipodidae.Eozapus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Dipodidae.Eozapus.unclassified_Eozapus;

/// <summary>
/// Abstract class for unclassified Eozapus (no rank).
/// NCBI TaxId: 3398079
/// </summary>
public abstract class unclassified_Eozapus : Eozapus, Iunclassified_Eozapus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Eozapus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3398079;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Eozapus";
}
