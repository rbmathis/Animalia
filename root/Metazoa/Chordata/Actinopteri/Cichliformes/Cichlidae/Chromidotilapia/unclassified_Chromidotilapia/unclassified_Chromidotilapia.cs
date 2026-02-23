using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Chromidotilapia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Chromidotilapia.unclassified_Chromidotilapia;

/// <summary>
/// Abstract class for unclassified Chromidotilapia (no rank).
/// NCBI TaxId: 2621216
/// </summary>
public abstract class unclassified_Chromidotilapia : Chromidotilapia, Iunclassified_Chromidotilapia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Chromidotilapia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621216;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Chromidotilapia";
}
