using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diplodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diplodactylidae.Toropuku;

/// <summary>
/// Abstract class for Toropuku (genus).
/// NCBI TaxId: 1413807
/// </summary>
public abstract class Toropuku : Diplodactylidae, IToropuku
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Toropuku";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1413807;

    /// <inheritdoc />
    public virtual string GenusName => "Toropuku";

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
