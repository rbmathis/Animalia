using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Dactyloscopidae.Platygillellus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Dactyloscopidae.Platygillellus.unclassified_Platygillellus;

/// <summary>
/// Abstract class for unclassified Platygillellus (no rank).
/// NCBI TaxId: 2635421
/// </summary>
public abstract class unclassified_Platygillellus : Platygillellus, Iunclassified_Platygillellus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Platygillellus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2635421;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Platygillellus";
}
