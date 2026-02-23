using AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Melanochelys;

/// <summary>
/// Abstract class for Melanochelys (genus).
/// NCBI TaxId: 74937
/// </summary>
public abstract class Melanochelys : Geoemydidae, IMelanochelys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Melanochelys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 74937;

    /// <inheritdoc />
    public virtual string GenusName => "Melanochelys";

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
