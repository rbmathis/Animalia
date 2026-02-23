using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Zenarchopteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Zenarchopteridae.Nomorhamphus;

/// <summary>
/// Abstract class for Nomorhamphus (genus).
/// NCBI TaxId: 129053
/// </summary>
public abstract class Nomorhamphus : Zenarchopteridae, INomorhamphus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nomorhamphus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 129053;

    /// <inheritdoc />
    public virtual string GenusName => "Nomorhamphus";

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
