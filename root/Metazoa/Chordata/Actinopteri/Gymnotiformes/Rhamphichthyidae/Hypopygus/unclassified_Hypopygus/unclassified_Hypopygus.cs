using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Rhamphichthyidae.Hypopygus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Rhamphichthyidae.Hypopygus.unclassified_Hypopygus;

/// <summary>
/// Abstract class for unclassified Hypopygus (no rank).
/// NCBI TaxId: 3101859
/// </summary>
public abstract class unclassified_Hypopygus : Hypopygus, Iunclassified_Hypopygus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hypopygus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3101859;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hypopygus";
}
