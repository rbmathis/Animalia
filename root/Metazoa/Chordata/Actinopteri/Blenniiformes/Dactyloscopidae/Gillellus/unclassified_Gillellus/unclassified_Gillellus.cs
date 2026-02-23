using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Dactyloscopidae.Gillellus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Dactyloscopidae.Gillellus.unclassified_Gillellus;

/// <summary>
/// Abstract class for unclassified Gillellus (no rank).
/// NCBI TaxId: 2622440
/// </summary>
public abstract class unclassified_Gillellus : Gillellus, Iunclassified_Gillellus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gillellus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2622440;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gillellus";
}
