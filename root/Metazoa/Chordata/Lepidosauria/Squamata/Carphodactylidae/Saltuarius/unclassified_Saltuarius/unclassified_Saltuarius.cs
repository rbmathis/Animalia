using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Carphodactylidae.Saltuarius;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Carphodactylidae.Saltuarius.unclassified_Saltuarius;

/// <summary>
/// Abstract class for unclassified Saltuarius (no rank).
/// NCBI TaxId: 2618372
/// </summary>
public abstract class unclassified_Saltuarius : Saltuarius, Iunclassified_Saltuarius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Saltuarius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2618372;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Saltuarius";
}
