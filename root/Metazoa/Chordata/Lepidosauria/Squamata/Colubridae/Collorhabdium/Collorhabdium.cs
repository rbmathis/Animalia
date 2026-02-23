using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Collorhabdium;

/// <summary>
/// Abstract class for Collorhabdium (genus).
/// NCBI TaxId: 1544002
/// </summary>
public abstract class Collorhabdium : Colubridae, ICollorhabdium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Collorhabdium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1544002;

    /// <inheritdoc />
    public virtual string GenusName => "Collorhabdium";

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
