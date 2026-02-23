using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pipridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pipridae.Pseudopipra;

/// <summary>
/// Abstract class for Pseudopipra (genus).
/// NCBI TaxId: 2840301
/// </summary>
public abstract class Pseudopipra : Pipridae, IPseudopipra
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudopipra";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2840301;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudopipra";

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
