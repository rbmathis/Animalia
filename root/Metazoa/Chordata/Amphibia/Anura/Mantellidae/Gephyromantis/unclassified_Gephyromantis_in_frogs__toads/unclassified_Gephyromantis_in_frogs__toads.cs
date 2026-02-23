using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Mantellidae.Gephyromantis;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Mantellidae.Gephyromantis.unclassified_Gephyromantis_in_frogs__toads;

/// <summary>
/// Abstract class for unclassified Gephyromantis (in: frogs & toads) (no rank).
/// NCBI TaxId: 3406944
/// </summary>
public abstract class unclassified_Gephyromantis_in_frogs__toads : Gephyromantis, Iunclassified_Gephyromantis_in_frogs__toads
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gephyromantis (in: frogs & toads)";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3406944;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gephyromantis_in_frogs__toads";
}
