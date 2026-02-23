using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Petrochromis;

/// <summary>
/// Abstract class for Petrochromis (genus).
/// NCBI TaxId: 28817
/// </summary>
public abstract class Petrochromis : Cichlidae, IPetrochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Petrochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 28817;

    /// <inheritdoc />
    public virtual string GenusName => "Petrochromis";

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
