using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Afurcagobius;

/// <summary>
/// Abstract class for Afurcagobius (genus).
/// NCBI TaxId: 613169
/// </summary>
public abstract class Afurcagobius : Gobiidae, IAfurcagobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Afurcagobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 613169;

    /// <inheritdoc />
    public virtual string GenusName => "Afurcagobius";

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
