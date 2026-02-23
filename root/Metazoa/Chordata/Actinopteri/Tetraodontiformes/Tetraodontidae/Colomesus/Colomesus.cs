using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Tetraodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Tetraodontidae.Colomesus;

/// <summary>
/// Abstract class for Colomesus (genus).
/// NCBI TaxId: 500392
/// </summary>
public abstract class Colomesus : Tetraodontidae, IColomesus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Colomesus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 500392;

    /// <inheritdoc />
    public virtual string GenusName => "Colomesus";

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
