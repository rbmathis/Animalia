using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Hesperoleucus;

/// <summary>
/// Abstract class for Hesperoleucus (genus).
/// NCBI TaxId: 164604
/// </summary>
public abstract class Hesperoleucus : Leuciscidae, IHesperoleucus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hesperoleucus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 164604;

    /// <inheritdoc />
    public virtual string GenusName => "Hesperoleucus";

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
