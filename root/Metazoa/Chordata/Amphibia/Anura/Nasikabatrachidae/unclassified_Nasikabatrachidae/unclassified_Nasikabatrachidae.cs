using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Nasikabatrachidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Nasikabatrachidae.unclassified_Nasikabatrachidae;

/// <summary>
/// Abstract class for unclassified Nasikabatrachidae (no rank).
/// NCBI TaxId: 259067
/// </summary>
public abstract class unclassified_Nasikabatrachidae : Nasikabatrachidae, Iunclassified_Nasikabatrachidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Nasikabatrachidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 259067;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Nasikabatrachidae";
}
