using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Stephopaedes;

/// <summary>
/// Abstract class for Stephopaedes (genus).
/// NCBI TaxId: 119768
/// </summary>
public abstract class Stephopaedes : Bufonidae, IStephopaedes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Stephopaedes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 119768;

    /// <inheritdoc />
    public virtual string GenusName => "Stephopaedes";

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
