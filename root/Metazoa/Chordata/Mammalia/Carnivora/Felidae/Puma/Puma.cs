using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae.Puma;

/// <summary>
/// Abstract class for Puma (genus).
/// NCBI TaxId: 146712
/// </summary>
public abstract class Puma : Felidae, IPuma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Puma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 146712;

    /// <inheritdoc />
    public virtual string GenusName => "Puma";

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
