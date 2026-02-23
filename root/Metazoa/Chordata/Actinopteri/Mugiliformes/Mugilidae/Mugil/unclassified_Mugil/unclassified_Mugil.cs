using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae.Mugil;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae.Mugil.unclassified_Mugil;

/// <summary>
/// Abstract class for unclassified Mugil (no rank).
/// NCBI TaxId: 2648279
/// </summary>
public abstract class unclassified_Mugil : Mugil, Iunclassified_Mugil
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Mugil";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2648279;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Mugil";
}
