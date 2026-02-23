using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gerrhosauridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gerrhosauridae.Tetradactylus;

/// <summary>
/// Abstract class for Tetradactylus (genus).
/// NCBI TaxId: 126623
/// </summary>
public abstract class Tetradactylus : Gerrhosauridae, ITetradactylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tetradactylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 126623;

    /// <inheritdoc />
    public virtual string GenusName => "Tetradactylus";

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
