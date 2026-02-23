using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae.Catopuma;

/// <summary>
/// Abstract class for Catopuma (genus).
/// NCBI TaxId: 61453
/// </summary>
public abstract class Catopuma : Felidae, ICatopuma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Catopuma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 61453;

    /// <inheritdoc />
    public virtual string GenusName => "Catopuma";

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
