using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Mantellidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Mantellidae.Spinomantis;

/// <summary>
/// Abstract class for Spinomantis (genus).
/// NCBI TaxId: 403237
/// </summary>
public abstract class Spinomantis : Mantellidae, ISpinomantis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Spinomantis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 403237;

    /// <inheritdoc />
    public virtual string GenusName => "Spinomantis";

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
