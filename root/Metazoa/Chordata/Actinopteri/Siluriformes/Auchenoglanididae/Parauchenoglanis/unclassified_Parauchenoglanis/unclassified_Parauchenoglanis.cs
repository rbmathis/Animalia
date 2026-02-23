using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Auchenoglanididae.Parauchenoglanis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Auchenoglanididae.Parauchenoglanis.unclassified_Parauchenoglanis;

/// <summary>
/// Abstract class for unclassified Parauchenoglanis (no rank).
/// NCBI TaxId: 2626521
/// </summary>
public abstract class unclassified_Parauchenoglanis : Parauchenoglanis, Iunclassified_Parauchenoglanis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Parauchenoglanis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626521;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Parauchenoglanis";
}
