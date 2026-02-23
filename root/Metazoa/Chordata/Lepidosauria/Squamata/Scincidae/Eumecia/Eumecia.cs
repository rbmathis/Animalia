using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Eumecia;

/// <summary>
/// Abstract class for Eumecia (genus).
/// NCBI TaxId: 246189
/// </summary>
public abstract class Eumecia : Scincidae, IEumecia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eumecia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 246189;

    /// <inheritdoc />
    public virtual string GenusName => "Eumecia";

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
