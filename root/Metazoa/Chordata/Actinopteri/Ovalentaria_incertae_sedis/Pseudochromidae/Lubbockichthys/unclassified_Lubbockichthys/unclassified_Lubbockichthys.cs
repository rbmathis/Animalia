using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pseudochromidae.Lubbockichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pseudochromidae.Lubbockichthys.unclassified_Lubbockichthys;

/// <summary>
/// Abstract class for unclassified Lubbockichthys (no rank).
/// NCBI TaxId: 2634769
/// </summary>
public abstract class unclassified_Lubbockichthys : Lubbockichthys, Iunclassified_Lubbockichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lubbockichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2634769;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lubbockichthys";
}
