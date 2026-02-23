using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Pharyngochromis;

/// <summary>
/// Abstract class for Pharyngochromis (genus).
/// NCBI TaxId: 311496
/// </summary>
public abstract class Pharyngochromis : Cichlidae, IPharyngochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pharyngochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 311496;

    /// <inheritdoc />
    public virtual string GenusName => "Pharyngochromis";

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
