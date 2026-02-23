using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paridae.Melaniparus;

/// <summary>
/// Abstract class for Melaniparus (genus).
/// NCBI TaxId: 1356369
/// </summary>
public abstract class Melaniparus : Paridae, IMelaniparus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Melaniparus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1356369;

    /// <inheritdoc />
    public virtual string GenusName => "Melaniparus";

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
