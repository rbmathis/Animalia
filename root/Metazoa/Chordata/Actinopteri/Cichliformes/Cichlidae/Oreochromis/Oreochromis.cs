using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Oreochromis;

/// <summary>
/// Abstract class for Oreochromis (genus).
/// NCBI TaxId: 8139
/// </summary>
public abstract class Oreochromis : Cichlidae, IOreochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oreochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8139;

    /// <inheritdoc />
    public virtual string GenusName => "Oreochromis";

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
