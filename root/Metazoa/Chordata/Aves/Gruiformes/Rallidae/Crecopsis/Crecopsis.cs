using AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Crecopsis;

/// <summary>
/// Abstract class for Crecopsis (genus).
/// NCBI TaxId: 2861773
/// </summary>
public abstract class Crecopsis : Rallidae, ICrecopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Crecopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2861773;

    /// <inheritdoc />
    public virtual string GenusName => "Crecopsis";

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
