using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Maluridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Maluridae.Chenorhamphus;

/// <summary>
/// Abstract class for Chenorhamphus (genus).
/// NCBI TaxId: 1931079
/// </summary>
public abstract class Chenorhamphus : Maluridae, IChenorhamphus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chenorhamphus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1931079;

    /// <inheritdoc />
    public virtual string GenusName => "Chenorhamphus";

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
