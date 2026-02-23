using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae.Nyctanolis;

/// <summary>
/// Abstract class for Nyctanolis (genus).
/// NCBI TaxId: 269192
/// </summary>
public abstract class Nyctanolis : Plethodontidae, INyctanolis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nyctanolis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 269192;

    /// <inheritdoc />
    public virtual string GenusName => "Nyctanolis";

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
