using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Astatoreochromis;

/// <summary>
/// Abstract class for Astatoreochromis (genus).
/// NCBI TaxId: 40170
/// </summary>
public abstract class Astatoreochromis : Cichlidae, IAstatoreochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Astatoreochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 40170;

    /// <inheritdoc />
    public virtual string GenusName => "Astatoreochromis";

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
