using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Tangachromis;

/// <summary>
/// Abstract class for Tangachromis (genus).
/// NCBI TaxId: 1811343
/// </summary>
public abstract class Tangachromis : Cichlidae, ITangachromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tangachromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1811343;

    /// <inheritdoc />
    public virtual string GenusName => "Tangachromis";

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
