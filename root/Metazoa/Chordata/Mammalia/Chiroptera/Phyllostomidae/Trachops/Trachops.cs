using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Trachops;

/// <summary>
/// Abstract class for Trachops (genus).
/// NCBI TaxId: 148059
/// </summary>
public abstract class Trachops : Phyllostomidae, ITrachops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trachops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 148059;

    /// <inheritdoc />
    public virtual string GenusName => "Trachops";

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
