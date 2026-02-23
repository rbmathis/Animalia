using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Belonidae.Tylosurus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Belonidae.Tylosurus.unclassified_Tylosurus;

/// <summary>
/// Abstract class for unclassified Tylosurus (no rank).
/// NCBI TaxId: 2625879
/// </summary>
public abstract class unclassified_Tylosurus : Tylosurus, Iunclassified_Tylosurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Tylosurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2625879;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Tylosurus";
}
