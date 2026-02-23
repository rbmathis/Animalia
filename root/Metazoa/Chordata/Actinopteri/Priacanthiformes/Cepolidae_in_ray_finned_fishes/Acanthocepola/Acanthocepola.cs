using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Priacanthiformes.Cepolidae_in_ray_finned_fishes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Priacanthiformes.Cepolidae_in_ray_finned_fishes.Acanthocepola;

/// <summary>
/// Abstract class for Acanthocepola (genus).
/// NCBI TaxId: 270596
/// </summary>
public abstract class Acanthocepola : Cepolidae_in_ray_finned_fishes, IAcanthocepola
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acanthocepola";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 270596;

    /// <inheritdoc />
    public virtual string GenusName => "Acanthocepola";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
