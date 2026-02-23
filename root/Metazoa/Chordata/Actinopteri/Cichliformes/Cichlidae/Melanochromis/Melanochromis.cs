using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Melanochromis;

/// <summary>
/// Abstract class for Melanochromis (genus).
/// NCBI TaxId: 27750
/// </summary>
public abstract class Melanochromis : Cichlidae, IMelanochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Melanochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 27750;

    /// <inheritdoc />
    public virtual string GenusName => "Melanochromis";

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
