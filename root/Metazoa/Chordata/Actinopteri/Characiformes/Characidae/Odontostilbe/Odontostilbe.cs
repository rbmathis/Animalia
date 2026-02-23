using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Odontostilbe;

/// <summary>
/// Abstract class for Odontostilbe (genus).
/// NCBI TaxId: 930359
/// </summary>
public abstract class Odontostilbe : Characidae, IOdontostilbe
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Odontostilbe";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 930359;

    /// <inheritdoc />
    public virtual string GenusName => "Odontostilbe";

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
