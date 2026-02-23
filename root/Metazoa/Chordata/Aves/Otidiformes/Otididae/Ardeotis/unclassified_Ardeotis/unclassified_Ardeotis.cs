using AnimalKingdom.root.Metazoa.Chordata.Aves.Otidiformes.Otididae.Ardeotis;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Otidiformes.Otididae.Ardeotis.unclassified_Ardeotis;

/// <summary>
/// Abstract class for unclassified Ardeotis (no rank).
/// NCBI TaxId: 2620367
/// </summary>
public abstract class unclassified_Ardeotis : Ardeotis, Iunclassified_Ardeotis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ardeotis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2620367;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ardeotis";
}
