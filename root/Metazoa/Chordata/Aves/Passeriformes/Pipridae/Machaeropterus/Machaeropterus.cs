using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pipridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pipridae.Machaeropterus;

/// <summary>
/// Abstract class for Machaeropterus (genus).
/// NCBI TaxId: 114315
/// </summary>
public abstract class Machaeropterus : Pipridae, IMachaeropterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Machaeropterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 114315;

    /// <inheritdoc />
    public virtual string GenusName => "Machaeropterus";

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
