using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Thoracochromis;

/// <summary>
/// Abstract class for Thoracochromis (genus).
/// NCBI TaxId: 227844
/// </summary>
public abstract class Thoracochromis : Cichlidae, IThoracochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Thoracochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 227844;

    /// <inheritdoc />
    public virtual string GenusName => "Thoracochromis";

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
