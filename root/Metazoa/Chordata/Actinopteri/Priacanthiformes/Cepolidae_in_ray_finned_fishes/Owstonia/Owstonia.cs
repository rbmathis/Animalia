using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Priacanthiformes.Cepolidae_in_ray_finned_fishes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Priacanthiformes.Cepolidae_in_ray_finned_fishes.Owstonia;

/// <summary>
/// Abstract class for Owstonia (genus).
/// NCBI TaxId: 990992
/// </summary>
public abstract class Owstonia : Cepolidae_in_ray_finned_fishes, IOwstonia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Owstonia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 990992;

    /// <inheritdoc />
    public virtual string GenusName => "Owstonia";

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
