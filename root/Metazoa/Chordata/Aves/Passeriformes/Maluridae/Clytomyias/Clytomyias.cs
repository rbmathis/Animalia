using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Maluridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Maluridae.Clytomyias;

/// <summary>
/// Abstract class for Clytomyias (genus).
/// NCBI TaxId: 720580
/// </summary>
public abstract class Clytomyias : Maluridae, IClytomyias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Clytomyias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 720580;

    /// <inheritdoc />
    public virtual string GenusName => "Clytomyias";

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
