using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Rhamphichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Rhamphichthyidae.Gymnorhamphichthys;

/// <summary>
/// Abstract class for Gymnorhamphichthys (genus).
/// NCBI TaxId: 36695
/// </summary>
public abstract class Gymnorhamphichthys : Rhamphichthyidae, IGymnorhamphichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gymnorhamphichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 36695;

    /// <inheritdoc />
    public virtual string GenusName => "Gymnorhamphichthys";

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
