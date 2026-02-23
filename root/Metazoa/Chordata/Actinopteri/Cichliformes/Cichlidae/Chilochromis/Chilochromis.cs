using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Chilochromis;

/// <summary>
/// Abstract class for Chilochromis (genus).
/// NCBI TaxId: 665436
/// </summary>
public abstract class Chilochromis : Cichlidae, IChilochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chilochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 665436;

    /// <inheritdoc />
    public virtual string GenusName => "Chilochromis";

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
