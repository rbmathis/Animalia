using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Eleutherodactylidae.Eleutherodactylus;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Eleutherodactylidae.Eleutherodactylus.unclassified_Eleutherodactylus_in_frogs__toads;

/// <summary>
/// Abstract class for unclassified Eleutherodactylus (in: frogs & toads) (no rank).
/// NCBI TaxId: 3406921
/// </summary>
public abstract class unclassified_Eleutherodactylus_in_frogs__toads : Eleutherodactylus, Iunclassified_Eleutherodactylus_in_frogs__toads
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Eleutherodactylus (in: frogs & toads)";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3406921;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Eleutherodactylus_in_frogs__toads";
}
