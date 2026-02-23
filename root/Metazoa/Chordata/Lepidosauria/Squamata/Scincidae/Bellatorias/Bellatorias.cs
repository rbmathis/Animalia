using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Bellatorias;

/// <summary>
/// Abstract class for Bellatorias (genus).
/// NCBI TaxId: 1041594
/// </summary>
public abstract class Bellatorias : Scincidae, IBellatorias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bellatorias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1041594;

    /// <inheritdoc />
    public virtual string GenusName => "Bellatorias";

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
