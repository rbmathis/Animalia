using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Zenarchopteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Zenarchopteridae.Hemirhamphodon;

/// <summary>
/// Abstract class for Hemirhamphodon (genus).
/// NCBI TaxId: 129047
/// </summary>
public abstract class Hemirhamphodon : Zenarchopteridae, IHemirhamphodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hemirhamphodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 129047;

    /// <inheritdoc />
    public virtual string GenusName => "Hemirhamphodon";

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
