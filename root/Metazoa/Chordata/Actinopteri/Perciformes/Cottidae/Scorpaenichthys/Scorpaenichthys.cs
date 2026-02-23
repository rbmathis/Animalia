using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Scorpaenichthys;

/// <summary>
/// Abstract class for Scorpaenichthys (genus).
/// NCBI TaxId: 52272
/// </summary>
public abstract class Scorpaenichthys : Cottidae, IScorpaenichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scorpaenichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 52272;

    /// <inheritdoc />
    public virtual string GenusName => "Scorpaenichthys";

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
