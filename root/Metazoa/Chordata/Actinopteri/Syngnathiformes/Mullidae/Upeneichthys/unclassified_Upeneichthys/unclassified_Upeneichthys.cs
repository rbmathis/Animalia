using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Mullidae.Upeneichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Mullidae.Upeneichthys.unclassified_Upeneichthys;

/// <summary>
/// Abstract class for unclassified Upeneichthys (no rank).
/// NCBI TaxId: 2639664
/// </summary>
public abstract class unclassified_Upeneichthys : Upeneichthys, Iunclassified_Upeneichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Upeneichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2639664;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Upeneichthys";
}
