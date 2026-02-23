using AnimalKingdom.root.Metazoa.Chordata.Testudines.Cheloniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Cheloniidae.Lepidochelys;

/// <summary>
/// Abstract class for Lepidochelys (genus).
/// NCBI TaxId: 8471
/// </summary>
public abstract class Lepidochelys : Cheloniidae, ILepidochelys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lepidochelys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8471;

    /// <inheritdoc />
    public virtual string GenusName => "Lepidochelys";

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
