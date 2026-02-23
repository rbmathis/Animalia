using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paridae.Pardaliparus;

/// <summary>
/// Abstract class for Pardaliparus (genus).
/// NCBI TaxId: 2185134
/// </summary>
public abstract class Pardaliparus : Paridae, IPardaliparus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pardaliparus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2185134;

    /// <inheritdoc />
    public virtual string GenusName => "Pardaliparus";

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
