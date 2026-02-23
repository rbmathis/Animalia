using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Amplorhinus;

/// <summary>
/// Abstract class for Amplorhinus (genus).
/// NCBI TaxId: 292906
/// </summary>
public abstract class Amplorhinus : Colubridae, IAmplorhinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Amplorhinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 292906;

    /// <inheritdoc />
    public virtual string GenusName => "Amplorhinus";

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
