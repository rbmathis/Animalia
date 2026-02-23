using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Rhamphichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Rhamphichthyidae.Steatogenys;

/// <summary>
/// Abstract class for Steatogenys (genus).
/// NCBI TaxId: 36685
/// </summary>
public abstract class Steatogenys : Rhamphichthyidae, ISteatogenys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Steatogenys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 36685;

    /// <inheritdoc />
    public virtual string GenusName => "Steatogenys";

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
