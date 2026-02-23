using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Eutaeniichthys;

/// <summary>
/// Abstract class for Eutaeniichthys (genus).
/// NCBI TaxId: 228542
/// </summary>
public abstract class Eutaeniichthys : Gobiidae, IEutaeniichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eutaeniichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 228542;

    /// <inheritdoc />
    public virtual string GenusName => "Eutaeniichthys";

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
