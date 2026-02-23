using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Graciliscincus;

/// <summary>
/// Abstract class for Graciliscincus (genus).
/// NCBI TaxId: 394129
/// </summary>
public abstract class Graciliscincus : Scincidae, IGraciliscincus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Graciliscincus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 394129;

    /// <inheritdoc />
    public virtual string GenusName => "Graciliscincus";

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
