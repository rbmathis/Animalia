using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Didelphimorphia.Didelphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Didelphimorphia.Didelphidae.Marmosops;

/// <summary>
/// Abstract class for Marmosops (genus).
/// NCBI TaxId: 42721
/// </summary>
public abstract class Marmosops : Didelphidae, IMarmosops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Marmosops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 42721;

    /// <inheritdoc />
    public virtual string GenusName => "Marmosops";

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
