using AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Aegolius;

/// <summary>
/// Abstract class for Aegolius (genus).
/// NCBI TaxId: 56264
/// </summary>
public abstract class Aegolius : Strigidae, IAegolius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aegolius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 56264;

    /// <inheritdoc />
    public virtual string GenusName => "Aegolius";

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
