using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Quilticohyla;

/// <summary>
/// Abstract class for Quilticohyla (genus).
/// NCBI TaxId: 2491336
/// </summary>
public abstract class Quilticohyla : Hylidae, IQuilticohyla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Quilticohyla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2491336;

    /// <inheritdoc />
    public virtual string GenusName => "Quilticohyla";

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
