using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diplodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diplodactylidae.Lucasium;

/// <summary>
/// Abstract class for Lucasium (genus).
/// NCBI TaxId: 453857
/// </summary>
public abstract class Lucasium : Diplodactylidae, ILucasium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lucasium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 453857;

    /// <inheritdoc />
    public virtual string GenusName => "Lucasium";

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
