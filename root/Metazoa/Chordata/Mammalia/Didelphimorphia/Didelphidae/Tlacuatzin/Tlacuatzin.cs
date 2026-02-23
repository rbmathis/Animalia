using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Didelphimorphia.Didelphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Didelphimorphia.Didelphidae.Tlacuatzin;

/// <summary>
/// Abstract class for Tlacuatzin (genus).
/// NCBI TaxId: 225727
/// </summary>
public abstract class Tlacuatzin : Didelphidae, ITlacuatzin
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tlacuatzin";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 225727;

    /// <inheritdoc />
    public virtual string GenusName => "Tlacuatzin";

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
