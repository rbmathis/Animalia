using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Maluridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Maluridae.Amytornis;

/// <summary>
/// Abstract class for Amytornis (genus).
/// NCBI TaxId: 266390
/// </summary>
public abstract class Amytornis : Maluridae, IAmytornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Amytornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 266390;

    /// <inheritdoc />
    public virtual string GenusName => "Amytornis";

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
