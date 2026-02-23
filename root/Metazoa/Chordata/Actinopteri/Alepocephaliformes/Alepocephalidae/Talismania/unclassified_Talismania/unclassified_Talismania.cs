using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Alepocephaliformes.Alepocephalidae.Talismania;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Alepocephaliformes.Alepocephalidae.Talismania.unclassified_Talismania;

/// <summary>
/// Abstract class for unclassified Talismania (no rank).
/// NCBI TaxId: 2619783
/// </summary>
public abstract class unclassified_Talismania : Talismania, Iunclassified_Talismania
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Talismania";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2619783;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Talismania";
}
