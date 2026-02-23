using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Apodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Apodidae.Tachymarptis;

/// <summary>
/// Abstract class for Tachymarptis (genus).
/// NCBI TaxId: 670358
/// </summary>
public abstract class Tachymarptis : Apodidae, ITachymarptis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tachymarptis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 670358;

    /// <inheritdoc />
    public virtual string GenusName => "Tachymarptis";

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
