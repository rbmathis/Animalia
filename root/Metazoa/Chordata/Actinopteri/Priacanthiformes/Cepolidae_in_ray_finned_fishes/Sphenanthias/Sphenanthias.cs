using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Priacanthiformes.Cepolidae_in_ray_finned_fishes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Priacanthiformes.Cepolidae_in_ray_finned_fishes.Sphenanthias;

/// <summary>
/// Abstract class for Sphenanthias (genus).
/// NCBI TaxId: 1131791
/// </summary>
public abstract class Sphenanthias : Cepolidae_in_ray_finned_fishes, ISphenanthias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sphenanthias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1131791;

    /// <inheritdoc />
    public virtual string GenusName => "Sphenanthias";

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
