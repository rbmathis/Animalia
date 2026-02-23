using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae.Ampelornis;

/// <summary>
/// Abstract class for Ampelornis (genus).
/// NCBI TaxId: 2767394
/// </summary>
public abstract class Ampelornis : Thamnophilidae, IAmpelornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ampelornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2767394;

    /// <inheritdoc />
    public virtual string GenusName => "Ampelornis";

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
