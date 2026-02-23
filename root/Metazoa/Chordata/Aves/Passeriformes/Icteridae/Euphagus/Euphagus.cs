using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae.Euphagus;

/// <summary>
/// Abstract class for Euphagus (genus).
/// NCBI TaxId: 84800
/// </summary>
public abstract class Euphagus : Icteridae, IEuphagus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Euphagus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 84800;

    /// <inheritdoc />
    public virtual string GenusName => "Euphagus";

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
