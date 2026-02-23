using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Hylomantis;

/// <summary>
/// Abstract class for Hylomantis (genus).
/// NCBI TaxId: 318362
/// </summary>
public abstract class Hylomantis : Hylidae, IHylomantis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hylomantis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 318362;

    /// <inheritdoc />
    public virtual string GenusName => "Hylomantis";

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
