using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Auchenoglanididae.Auchenoglanis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Auchenoglanididae.Auchenoglanis.unclassified_Auchenoglanis;

/// <summary>
/// Abstract class for unclassified Auchenoglanis (no rank).
/// NCBI TaxId: 2621863
/// </summary>
public abstract class unclassified_Auchenoglanis : Auchenoglanis, Iunclassified_Auchenoglanis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Auchenoglanis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621863;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Auchenoglanis";
}
