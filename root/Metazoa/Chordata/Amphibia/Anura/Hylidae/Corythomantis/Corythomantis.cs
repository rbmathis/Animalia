using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Corythomantis;

/// <summary>
/// Abstract class for Corythomantis (genus).
/// NCBI TaxId: 318272
/// </summary>
public abstract class Corythomantis : Hylidae, ICorythomantis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Corythomantis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 318272;

    /// <inheritdoc />
    public virtual string GenusName => "Corythomantis";

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
