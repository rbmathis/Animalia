using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Muraenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Muraenidae.Channomuraena;

/// <summary>
/// Abstract class for Channomuraena (genus).
/// NCBI TaxId: 1916795
/// </summary>
public abstract class Channomuraena : Muraenidae, IChannomuraena
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Channomuraena";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1916795;

    /// <inheritdoc />
    public virtual string GenusName => "Channomuraena";

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
