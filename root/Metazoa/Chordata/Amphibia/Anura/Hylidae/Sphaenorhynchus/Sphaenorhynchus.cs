using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Sphaenorhynchus;

/// <summary>
/// Abstract class for Sphaenorhynchus (genus).
/// NCBI TaxId: 279983
/// </summary>
public abstract class Sphaenorhynchus : Hylidae, ISphaenorhynchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sphaenorhynchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 279983;

    /// <inheritdoc />
    public virtual string GenusName => "Sphaenorhynchus";

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
