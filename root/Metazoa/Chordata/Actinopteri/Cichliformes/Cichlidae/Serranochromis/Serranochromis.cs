using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Serranochromis;

/// <summary>
/// Abstract class for Serranochromis (genus).
/// NCBI TaxId: 50902
/// </summary>
public abstract class Serranochromis : Cichlidae, ISerranochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Serranochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 50902;

    /// <inheritdoc />
    public virtual string GenusName => "Serranochromis";

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
