using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Dasyuromorphia.Dasyuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Dasyuromorphia.Dasyuridae.Dasycercus;

/// <summary>
/// Abstract class for Dasycercus (genus).
/// NCBI TaxId: 32541
/// </summary>
public abstract class Dasycercus : Dasyuridae, IDasycercus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dasycercus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 32541;

    /// <inheritdoc />
    public virtual string GenusName => "Dasycercus";

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
