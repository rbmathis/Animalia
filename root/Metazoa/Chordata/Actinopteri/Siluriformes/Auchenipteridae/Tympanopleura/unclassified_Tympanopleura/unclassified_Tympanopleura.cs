using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Auchenipteridae.Tympanopleura;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Auchenipteridae.Tympanopleura.unclassified_Tympanopleura;

/// <summary>
/// Abstract class for unclassified Tympanopleura (no rank).
/// NCBI TaxId: 2634275
/// </summary>
public abstract class unclassified_Tympanopleura : Tympanopleura, Iunclassified_Tympanopleura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Tympanopleura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2634275;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Tympanopleura";
}
