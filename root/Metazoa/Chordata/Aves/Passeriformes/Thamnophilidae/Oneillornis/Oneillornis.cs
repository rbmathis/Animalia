using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae.Oneillornis;

/// <summary>
/// Abstract class for Oneillornis (genus).
/// NCBI TaxId: 2767939
/// </summary>
public abstract class Oneillornis : Thamnophilidae, IOneillornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oneillornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2767939;

    /// <inheritdoc />
    public virtual string GenusName => "Oneillornis";

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
