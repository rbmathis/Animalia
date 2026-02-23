using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Lichnochromis;

/// <summary>
/// Abstract class for Lichnochromis (genus).
/// NCBI TaxId: 934811
/// </summary>
public abstract class Lichnochromis : Cichlidae, ILichnochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lichnochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 934811;

    /// <inheritdoc />
    public virtual string GenusName => "Lichnochromis";

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
