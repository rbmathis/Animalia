using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Ptychohyla;

/// <summary>
/// Abstract class for Ptychohyla (genus).
/// NCBI TaxId: 317389
/// </summary>
public abstract class Ptychohyla : Hylidae, IPtychohyla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ptychohyla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 317389;

    /// <inheritdoc />
    public virtual string GenusName => "Ptychohyla";

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
