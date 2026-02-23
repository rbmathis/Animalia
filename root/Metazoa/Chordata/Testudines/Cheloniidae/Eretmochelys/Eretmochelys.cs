using AnimalKingdom.root.Metazoa.Chordata.Testudines.Cheloniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Cheloniidae.Eretmochelys;

/// <summary>
/// Abstract class for Eretmochelys (genus).
/// NCBI TaxId: 27786
/// </summary>
public abstract class Eretmochelys : Cheloniidae, IEretmochelys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eretmochelys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 27786;

    /// <inheritdoc />
    public virtual string GenusName => "Eretmochelys";

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
