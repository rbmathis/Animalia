using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paridae.Sittiparus;

/// <summary>
/// Abstract class for Sittiparus (genus).
/// NCBI TaxId: 1356396
/// </summary>
public abstract class Sittiparus : Paridae, ISittiparus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sittiparus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1356396;

    /// <inheritdoc />
    public virtual string GenusName => "Sittiparus";

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
