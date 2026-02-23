using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Rhamphichthyidae.Rhamphichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Rhamphichthyidae.Rhamphichthys.unclassified_Rhamphichthys;

/// <summary>
/// Abstract class for unclassified Rhamphichthys (no rank).
/// NCBI TaxId: 2630753
/// </summary>
public abstract class unclassified_Rhamphichthys : Rhamphichthys, Iunclassified_Rhamphichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Rhamphichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630753;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Rhamphichthys";
}
