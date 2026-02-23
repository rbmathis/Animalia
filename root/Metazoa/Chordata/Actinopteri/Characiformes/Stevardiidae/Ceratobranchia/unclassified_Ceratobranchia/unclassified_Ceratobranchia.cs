using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Ceratobranchia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Ceratobranchia.unclassified_Ceratobranchia;

/// <summary>
/// Abstract class for unclassified Ceratobranchia (no rank).
/// NCBI TaxId: 2632254
/// </summary>
public abstract class unclassified_Ceratobranchia : Ceratobranchia, Iunclassified_Ceratobranchia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ceratobranchia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2632254;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ceratobranchia";
}
