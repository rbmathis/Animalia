using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae.Amblyramphus;

/// <summary>
/// Abstract class for Amblyramphus (genus).
/// NCBI TaxId: 84811
/// </summary>
public abstract class Amblyramphus : Icteridae, IAmblyramphus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Amblyramphus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 84811;

    /// <inheritdoc />
    public virtual string GenusName => "Amblyramphus";

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
