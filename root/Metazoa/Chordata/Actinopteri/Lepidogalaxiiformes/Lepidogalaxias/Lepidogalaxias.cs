using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lepidogalaxiiformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lepidogalaxiiformes.Lepidogalaxias;

/// <summary>
/// Abstract class for Lepidogalaxias (genus).
/// NCBI TaxId: 89577
/// </summary>
public abstract class Lepidogalaxias : Lepidogalaxiiformes, ILepidogalaxias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lepidogalaxias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 89577;

    /// <inheritdoc />
    public virtual string GenusName => "Lepidogalaxias";

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
