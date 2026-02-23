using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Rondonops;

/// <summary>
/// Abstract class for Rondonops (genus).
/// NCBI TaxId: 3064244
/// </summary>
public abstract class Rondonops : Gymnophthalmidae, IRondonops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rondonops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3064244;

    /// <inheritdoc />
    public virtual string GenusName => "Rondonops";

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
