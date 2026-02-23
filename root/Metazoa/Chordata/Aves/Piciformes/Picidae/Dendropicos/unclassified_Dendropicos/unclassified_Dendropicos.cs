using AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Dendropicos;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Dendropicos.unclassified_Dendropicos;

/// <summary>
/// Abstract class for unclassified Dendropicos (no rank).
/// NCBI TaxId: 2632814
/// </summary>
public abstract class unclassified_Dendropicos : Dendropicos, Iunclassified_Dendropicos
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Dendropicos";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2632814;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Dendropicos";
}
