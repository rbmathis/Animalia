using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Distichodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Distichodontidae.Neolebias;

/// <summary>
/// Abstract class for Neolebias (genus).
/// NCBI TaxId: 304063
/// </summary>
public abstract class Neolebias : Distichodontidae, INeolebias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neolebias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 304063;

    /// <inheritdoc />
    public virtual string GenusName => "Neolebias";

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
