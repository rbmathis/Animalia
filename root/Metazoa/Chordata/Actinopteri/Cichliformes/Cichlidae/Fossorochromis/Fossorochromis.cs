using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Fossorochromis;

/// <summary>
/// Abstract class for Fossorochromis (genus).
/// NCBI TaxId: 137270
/// </summary>
public abstract class Fossorochromis : Cichlidae, IFossorochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Fossorochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 137270;

    /// <inheritdoc />
    public virtual string GenusName => "Fossorochromis";

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
