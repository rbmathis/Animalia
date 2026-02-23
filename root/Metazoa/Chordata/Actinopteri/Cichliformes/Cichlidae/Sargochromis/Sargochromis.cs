using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Sargochromis;

/// <summary>
/// Abstract class for Sargochromis (genus).
/// NCBI TaxId: 311501
/// </summary>
public abstract class Sargochromis : Cichlidae, ISargochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sargochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 311501;

    /// <inheritdoc />
    public virtual string GenusName => "Sargochromis";

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
