using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Pseudocrenilabrus;

/// <summary>
/// Abstract class for Pseudocrenilabrus (genus).
/// NCBI TaxId: 50811
/// </summary>
public abstract class Pseudocrenilabrus : Cichlidae, IPseudocrenilabrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudocrenilabrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 50811;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudocrenilabrus";

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
