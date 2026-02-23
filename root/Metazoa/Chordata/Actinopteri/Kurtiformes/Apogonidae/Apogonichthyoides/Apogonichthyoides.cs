using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.Apogonichthyoides;

/// <summary>
/// Abstract class for Apogonichthyoides (genus).
/// NCBI TaxId: 1003910
/// </summary>
public abstract class Apogonichthyoides : Apogonidae, IApogonichthyoides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Apogonichthyoides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1003910;

    /// <inheritdoc />
    public virtual string GenusName => "Apogonichthyoides";

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
