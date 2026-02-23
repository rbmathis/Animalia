using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Trypauchenichthys;

/// <summary>
/// Abstract class for Trypauchenichthys (genus).
/// NCBI TaxId: 3362369
/// </summary>
public abstract class Trypauchenichthys : Gobiidae, ITrypauchenichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trypauchenichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3362369;

    /// <inheritdoc />
    public virtual string GenusName => "Trypauchenichthys";

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
