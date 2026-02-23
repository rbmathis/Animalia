using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Paracontias;

/// <summary>
/// Abstract class for Paracontias (genus).
/// NCBI TaxId: 249502
/// </summary>
public abstract class Paracontias : Scincidae, IParacontias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paracontias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 249502;

    /// <inheritdoc />
    public virtual string GenusName => "Paracontias";

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
