using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ceratophryidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ceratophryidae.Telmatobius;

/// <summary>
/// Abstract class for Telmatobius (genus).
/// NCBI TaxId: 93484
/// </summary>
public abstract class Telmatobius : Ceratophryidae, ITelmatobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Telmatobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 93484;

    /// <inheritdoc />
    public virtual string GenusName => "Telmatobius";

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
