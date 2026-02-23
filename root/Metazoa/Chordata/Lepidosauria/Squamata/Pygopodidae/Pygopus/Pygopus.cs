using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Pygopodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Pygopodidae.Pygopus;

/// <summary>
/// Abstract class for Pygopus (genus).
/// NCBI TaxId: 207566
/// </summary>
public abstract class Pygopus : Pygopodidae, IPygopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pygopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 207566;

    /// <inheritdoc />
    public virtual string GenusName => "Pygopus";

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
