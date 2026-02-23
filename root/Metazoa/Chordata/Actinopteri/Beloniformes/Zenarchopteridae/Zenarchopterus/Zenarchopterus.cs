using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Zenarchopteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Zenarchopteridae.Zenarchopterus;

/// <summary>
/// Abstract class for Zenarchopterus (genus).
/// NCBI TaxId: 131628
/// </summary>
public abstract class Zenarchopterus : Zenarchopteridae, IZenarchopterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Zenarchopterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 131628;

    /// <inheritdoc />
    public virtual string GenusName => "Zenarchopterus";

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
