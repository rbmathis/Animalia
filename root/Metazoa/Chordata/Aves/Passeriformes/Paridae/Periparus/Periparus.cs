using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paridae.Periparus;

/// <summary>
/// Abstract class for Periparus (genus).
/// NCBI TaxId: 156566
/// </summary>
public abstract class Periparus : Paridae, IPeriparus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Periparus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 156566;

    /// <inheritdoc />
    public virtual string GenusName => "Periparus";

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
