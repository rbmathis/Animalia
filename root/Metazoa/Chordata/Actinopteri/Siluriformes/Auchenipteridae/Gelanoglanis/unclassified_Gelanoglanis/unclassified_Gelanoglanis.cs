using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Auchenipteridae.Gelanoglanis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Auchenipteridae.Gelanoglanis.unclassified_Gelanoglanis;

/// <summary>
/// Abstract class for unclassified Gelanoglanis (no rank).
/// NCBI TaxId: 2621463
/// </summary>
public abstract class unclassified_Gelanoglanis : Gelanoglanis, Iunclassified_Gelanoglanis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gelanoglanis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621463;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gelanoglanis";
}
