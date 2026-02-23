using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Aristochromis;

/// <summary>
/// Abstract class for Aristochromis (genus).
/// NCBI TaxId: 143554
/// </summary>
public abstract class Aristochromis : Cichlidae, IAristochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aristochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 143554;

    /// <inheritdoc />
    public virtual string GenusName => "Aristochromis";

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
