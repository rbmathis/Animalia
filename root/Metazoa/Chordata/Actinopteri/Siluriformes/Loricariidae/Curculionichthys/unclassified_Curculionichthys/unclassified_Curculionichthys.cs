using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Curculionichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Curculionichthys.unclassified_Curculionichthys;

/// <summary>
/// Abstract class for unclassified Curculionichthys (no rank).
/// NCBI TaxId: 2835602
/// </summary>
public abstract class unclassified_Curculionichthys : Curculionichthys, Iunclassified_Curculionichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Curculionichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2835602;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Curculionichthys";
}
