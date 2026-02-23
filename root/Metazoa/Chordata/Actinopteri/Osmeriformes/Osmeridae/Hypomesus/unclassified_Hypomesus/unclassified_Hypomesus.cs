using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osmeriformes.Osmeridae.Hypomesus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osmeriformes.Osmeridae.Hypomesus.unclassified_Hypomesus;

/// <summary>
/// Abstract class for unclassified Hypomesus (no rank).
/// NCBI TaxId: 3563816
/// </summary>
public abstract class unclassified_Hypomesus : Hypomesus, Iunclassified_Hypomesus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hypomesus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3563816;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hypomesus";
}
