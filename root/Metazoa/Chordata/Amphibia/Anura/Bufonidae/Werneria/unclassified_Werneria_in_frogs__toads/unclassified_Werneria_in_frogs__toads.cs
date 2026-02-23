using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Werneria;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Werneria.unclassified_Werneria_in_frogs__toads;

/// <summary>
/// Abstract class for unclassified Werneria (in: frogs & toads) (no rank).
/// NCBI TaxId: 2689044
/// </summary>
public abstract class unclassified_Werneria_in_frogs__toads : Werneria, Iunclassified_Werneria_in_frogs__toads
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Werneria (in: frogs & toads)";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2689044;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Werneria_in_frogs__toads";
}
