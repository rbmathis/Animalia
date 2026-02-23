using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Diporiphora;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Diporiphora.unclassified_Diporiphora;

/// <summary>
/// Abstract class for unclassified Diporiphora (no rank).
/// NCBI TaxId: 2795374
/// </summary>
public abstract class unclassified_Diporiphora : Diporiphora, Iunclassified_Diporiphora
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Diporiphora";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2795374;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Diporiphora";
}
