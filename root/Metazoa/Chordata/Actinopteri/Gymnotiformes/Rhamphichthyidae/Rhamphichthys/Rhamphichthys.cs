using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Rhamphichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Rhamphichthyidae.Rhamphichthys;

/// <summary>
/// Abstract class for Rhamphichthys (genus).
/// NCBI TaxId: 36693
/// </summary>
public abstract class Rhamphichthys : Rhamphichthyidae, IRhamphichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhamphichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 36693;

    /// <inheritdoc />
    public virtual string GenusName => "Rhamphichthys";

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
