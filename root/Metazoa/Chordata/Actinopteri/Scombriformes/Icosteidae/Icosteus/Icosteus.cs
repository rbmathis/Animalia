using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Icosteidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Icosteidae.Icosteus;

/// <summary>
/// Abstract class for Icosteus (genus).
/// NCBI TaxId: 215385
/// </summary>
public abstract class Icosteus : Icosteidae, IIcosteus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Icosteus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 215385;

    /// <inheritdoc />
    public virtual string GenusName => "Icosteus";

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
