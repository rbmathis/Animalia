using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Economidichthys;

/// <summary>
/// Abstract class for Economidichthys (genus).
/// NCBI TaxId: 257724
/// </summary>
public abstract class Economidichthys : Gobiidae, IEconomidichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Economidichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 257724;

    /// <inheritdoc />
    public virtual string GenusName => "Economidichthys";

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
