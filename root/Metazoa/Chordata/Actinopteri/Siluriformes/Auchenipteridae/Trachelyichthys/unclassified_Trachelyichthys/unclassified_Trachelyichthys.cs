using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Auchenipteridae.Trachelyichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Auchenipteridae.Trachelyichthys.unclassified_Trachelyichthys;

/// <summary>
/// Abstract class for unclassified Trachelyichthys (no rank).
/// NCBI TaxId: 2634412
/// </summary>
public abstract class unclassified_Trachelyichthys : Trachelyichthys, Iunclassified_Trachelyichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Trachelyichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2634412;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Trachelyichthys";
}
