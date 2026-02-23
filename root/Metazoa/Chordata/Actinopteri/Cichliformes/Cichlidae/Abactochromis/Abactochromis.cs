using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Abactochromis;

/// <summary>
/// Abstract class for Abactochromis (genus).
/// NCBI TaxId: 2760992
/// </summary>
public abstract class Abactochromis : Cichlidae, IAbactochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Abactochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2760992;

    /// <inheritdoc />
    public virtual string GenusName => "Abactochromis";

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
