using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Cheilodactylidae.Nemadactylus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Cheilodactylidae.Nemadactylus.unclassified_Nemadactylus;

/// <summary>
/// Abstract class for unclassified Nemadactylus (no rank).
/// NCBI TaxId: 2647931
/// </summary>
public abstract class unclassified_Nemadactylus : Nemadactylus, Iunclassified_Nemadactylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Nemadactylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2647931;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Nemadactylus";
}
