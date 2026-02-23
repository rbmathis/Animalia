using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pipridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pipridae.Neopelma;

/// <summary>
/// Abstract class for Neopelma (genus).
/// NCBI TaxId: 114328
/// </summary>
public abstract class Neopelma : Pipridae, INeopelma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neopelma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 114328;

    /// <inheritdoc />
    public virtual string GenusName => "Neopelma";

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
