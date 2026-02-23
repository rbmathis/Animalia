using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Lerista;

/// <summary>
/// Abstract class for Lerista (genus).
/// NCBI TaxId: 66057
/// </summary>
public abstract class Lerista : Scincidae, ILerista
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lerista";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 66057;

    /// <inheritdoc />
    public virtual string GenusName => "Lerista";

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
