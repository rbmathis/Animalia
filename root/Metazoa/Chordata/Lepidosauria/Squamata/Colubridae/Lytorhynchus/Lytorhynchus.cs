using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Lytorhynchus;

/// <summary>
/// Abstract class for Lytorhynchus (genus).
/// NCBI TaxId: 224559
/// </summary>
public abstract class Lytorhynchus : Colubridae, ILytorhynchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lytorhynchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 224559;

    /// <inheritdoc />
    public virtual string GenusName => "Lytorhynchus";

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
