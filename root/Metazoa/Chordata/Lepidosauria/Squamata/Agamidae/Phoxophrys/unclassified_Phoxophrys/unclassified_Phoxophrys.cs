using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Phoxophrys;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Phoxophrys.unclassified_Phoxophrys;

/// <summary>
/// Abstract class for unclassified Phoxophrys (no rank).
/// NCBI TaxId: 3467921
/// </summary>
public abstract class unclassified_Phoxophrys : Phoxophrys, Iunclassified_Phoxophrys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Phoxophrys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3467921;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Phoxophrys";
}
