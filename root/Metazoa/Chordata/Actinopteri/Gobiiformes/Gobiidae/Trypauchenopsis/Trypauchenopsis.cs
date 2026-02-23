using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Trypauchenopsis;

/// <summary>
/// Abstract class for Trypauchenopsis (genus).
/// NCBI TaxId: 1738907
/// </summary>
public abstract class Trypauchenopsis : Gobiidae, ITrypauchenopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trypauchenopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1738907;

    /// <inheritdoc />
    public virtual string GenusName => "Trypauchenopsis";

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
