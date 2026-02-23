using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Phyllops;

/// <summary>
/// Abstract class for Phyllops (genus).
/// NCBI TaxId: 148027
/// </summary>
public abstract class Phyllops : Phyllostomidae, IPhyllops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phyllops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 148027;

    /// <inheritdoc />
    public virtual string GenusName => "Phyllops";

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
