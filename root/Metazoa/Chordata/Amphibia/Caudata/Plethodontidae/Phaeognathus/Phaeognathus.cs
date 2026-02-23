using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae.Phaeognathus;

/// <summary>
/// Abstract class for Phaeognathus (genus).
/// NCBI TaxId: 52109
/// </summary>
public abstract class Phaeognathus : Plethodontidae, IPhaeognathus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phaeognathus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 52109;

    /// <inheritdoc />
    public virtual string GenusName => "Phaeognathus";

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
