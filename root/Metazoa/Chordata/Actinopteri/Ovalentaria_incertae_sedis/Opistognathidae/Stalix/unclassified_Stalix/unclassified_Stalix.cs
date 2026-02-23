using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Opistognathidae.Stalix;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Opistognathidae.Stalix.unclassified_Stalix;

/// <summary>
/// Abstract class for unclassified Stalix (no rank).
/// NCBI TaxId: 2768226
/// </summary>
public abstract class unclassified_Stalix : Stalix, Iunclassified_Stalix
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Stalix";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2768226;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Stalix";
}
