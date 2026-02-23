using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Haplotaxodon;

/// <summary>
/// Abstract class for Haplotaxodon (genus).
/// NCBI TaxId: 70785
/// </summary>
public abstract class Haplotaxodon : Cichlidae, IHaplotaxodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Haplotaxodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 70785;

    /// <inheritdoc />
    public virtual string GenusName => "Haplotaxodon";

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
