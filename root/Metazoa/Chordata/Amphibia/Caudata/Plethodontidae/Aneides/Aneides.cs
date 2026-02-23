using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae.Aneides;

/// <summary>
/// Abstract class for Aneides (genus).
/// NCBI TaxId: 57540
/// </summary>
public abstract class Aneides : Plethodontidae, IAneides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aneides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 57540;

    /// <inheritdoc />
    public virtual string GenusName => "Aneides";

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
