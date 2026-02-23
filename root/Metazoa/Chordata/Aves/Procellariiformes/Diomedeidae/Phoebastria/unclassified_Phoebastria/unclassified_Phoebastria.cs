using AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Diomedeidae.Phoebastria;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Diomedeidae.Phoebastria.unclassified_Phoebastria;

/// <summary>
/// Abstract class for unclassified Phoebastria (no rank).
/// NCBI TaxId: 3243342
/// </summary>
public abstract class unclassified_Phoebastria : Phoebastria, Iunclassified_Phoebastria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Phoebastria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3243342;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Phoebastria";
}
