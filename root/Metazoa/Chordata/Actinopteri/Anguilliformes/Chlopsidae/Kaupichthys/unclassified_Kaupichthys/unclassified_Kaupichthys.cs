using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Chlopsidae.Kaupichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Chlopsidae.Kaupichthys.unclassified_Kaupichthys;

/// <summary>
/// Abstract class for unclassified Kaupichthys (no rank).
/// NCBI TaxId: 2619937
/// </summary>
public abstract class unclassified_Kaupichthys : Kaupichthys, Iunclassified_Kaupichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Kaupichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2619937;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Kaupichthys";
}
