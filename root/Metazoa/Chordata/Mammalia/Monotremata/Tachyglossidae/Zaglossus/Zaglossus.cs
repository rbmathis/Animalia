using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Monotremata.Tachyglossidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Monotremata.Tachyglossidae.Zaglossus;

/// <summary>
/// Abstract class for Zaglossus (genus).
/// NCBI TaxId: 33542
/// </summary>
public abstract class Zaglossus : Tachyglossidae, IZaglossus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Zaglossus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 33542;

    /// <inheritdoc />
    public virtual string GenusName => "Zaglossus";

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
