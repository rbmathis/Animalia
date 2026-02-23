using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.Sphaeramia;

/// <summary>
/// Abstract class for Sphaeramia (genus).
/// NCBI TaxId: 375763
/// </summary>
public abstract class Sphaeramia : Apogonidae, ISphaeramia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sphaeramia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 375763;

    /// <inheritdoc />
    public virtual string GenusName => "Sphaeramia";

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
