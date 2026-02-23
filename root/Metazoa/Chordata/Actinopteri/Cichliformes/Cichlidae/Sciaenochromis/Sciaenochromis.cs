using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Sciaenochromis;

/// <summary>
/// Abstract class for Sciaenochromis (genus).
/// NCBI TaxId: 136864
/// </summary>
public abstract class Sciaenochromis : Cichlidae, ISciaenochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sciaenochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 136864;

    /// <inheritdoc />
    public virtual string GenusName => "Sciaenochromis";

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
