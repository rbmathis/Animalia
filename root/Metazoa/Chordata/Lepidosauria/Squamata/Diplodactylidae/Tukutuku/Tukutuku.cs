using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diplodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diplodactylidae.Tukutuku;

/// <summary>
/// Abstract class for Tukutuku (genus).
/// NCBI TaxId: 1413806
/// </summary>
public abstract class Tukutuku : Diplodactylidae, ITukutuku
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tukutuku";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1413806;

    /// <inheritdoc />
    public virtual string GenusName => "Tukutuku";

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
