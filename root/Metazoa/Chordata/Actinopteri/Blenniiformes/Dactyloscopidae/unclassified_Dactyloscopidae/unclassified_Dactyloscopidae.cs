using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Dactyloscopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Dactyloscopidae.unclassified_Dactyloscopidae;

/// <summary>
/// Abstract class for unclassified Dactyloscopidae (no rank).
/// NCBI TaxId: 3456248
/// </summary>
public abstract class unclassified_Dactyloscopidae : Dactyloscopidae, Iunclassified_Dactyloscopidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Dactyloscopidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3456248;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Dactyloscopidae";
}
