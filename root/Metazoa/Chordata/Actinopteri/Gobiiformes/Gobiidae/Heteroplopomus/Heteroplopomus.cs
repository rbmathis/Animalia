using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Heteroplopomus;

/// <summary>
/// Abstract class for Heteroplopomus (genus).
/// NCBI TaxId: 2834873
/// </summary>
public abstract class Heteroplopomus : Gobiidae, IHeteroplopomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Heteroplopomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2834873;

    /// <inheritdoc />
    public virtual string GenusName => "Heteroplopomus";

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
