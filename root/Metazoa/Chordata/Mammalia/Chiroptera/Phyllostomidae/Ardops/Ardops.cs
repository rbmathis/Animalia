using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Ardops;

/// <summary>
/// Abstract class for Ardops (genus).
/// NCBI TaxId: 148023
/// </summary>
public abstract class Ardops : Phyllostomidae, IArdops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ardops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 148023;

    /// <inheritdoc />
    public virtual string GenusName => "Ardops";

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
