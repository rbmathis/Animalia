using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Phyllorhynchus;

/// <summary>
/// Abstract class for Phyllorhynchus (genus).
/// NCBI TaxId: 186558
/// </summary>
public abstract class Phyllorhynchus : Colubridae, IPhyllorhynchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phyllorhynchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 186558;

    /// <inheritdoc />
    public virtual string GenusName => "Phyllorhynchus";

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
