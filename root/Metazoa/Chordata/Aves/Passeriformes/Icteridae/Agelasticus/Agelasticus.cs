using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae.Agelasticus;

/// <summary>
/// Abstract class for Agelasticus (genus).
/// NCBI TaxId: 2820825
/// </summary>
public abstract class Agelasticus : Icteridae, IAgelasticus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Agelasticus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2820825;

    /// <inheritdoc />
    public virtual string GenusName => "Agelasticus";

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
