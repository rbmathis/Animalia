using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Trachichthyiformes.Monocentridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Trachichthyiformes.Monocentridae.Monocentris;

/// <summary>
/// Abstract class for Monocentris (genus).
/// NCBI TaxId: 181434
/// </summary>
public abstract class Monocentris : Monocentridae, IMonocentris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Monocentris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 181434;

    /// <inheritdoc />
    public virtual string GenusName => "Monocentris";

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
