using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Didemnidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Didemnidae.Lissoclinum;

/// <summary>
/// Abstract class for Lissoclinum (genus).
/// NCBI TaxId: 13109
/// </summary>
public abstract class Lissoclinum : Didemnidae, ILissoclinum
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lissoclinum";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 13109;

    /// <inheritdoc />
    public virtual string GenusName => "Lissoclinum";

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
