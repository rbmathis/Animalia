using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Liodytes;

/// <summary>
/// Abstract class for Liodytes (genus).
/// NCBI TaxId: 2025165
/// </summary>
public abstract class Liodytes : Colubridae, ILiodytes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Liodytes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2025165;

    /// <inheritdoc />
    public virtual string GenusName => "Liodytes";

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
