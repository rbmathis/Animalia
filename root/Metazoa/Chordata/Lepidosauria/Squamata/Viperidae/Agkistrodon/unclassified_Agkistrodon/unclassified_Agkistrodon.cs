using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae.Agkistrodon;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae.Agkistrodon.unclassified_Agkistrodon;

/// <summary>
/// Abstract class for unclassified Agkistrodon (no rank).
/// NCBI TaxId: 3467894
/// </summary>
public abstract class unclassified_Agkistrodon : Agkistrodon, Iunclassified_Agkistrodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Agkistrodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3467894;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Agkistrodon";
}
