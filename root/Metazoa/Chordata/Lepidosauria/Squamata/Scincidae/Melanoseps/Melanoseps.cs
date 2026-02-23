using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Melanoseps;

/// <summary>
/// Abstract class for Melanoseps (genus).
/// NCBI TaxId: 230626
/// </summary>
public abstract class Melanoseps : Scincidae, IMelanoseps
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Melanoseps";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 230626;

    /// <inheritdoc />
    public virtual string GenusName => "Melanoseps";

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
