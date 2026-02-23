using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Poeciliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Poeciliidae.Priapichthys;

/// <summary>
/// Abstract class for Priapichthys (genus).
/// NCBI TaxId: 188120
/// </summary>
public abstract class Priapichthys : Poeciliidae, IPriapichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Priapichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 188120;

    /// <inheritdoc />
    public virtual string GenusName => "Priapichthys";

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
