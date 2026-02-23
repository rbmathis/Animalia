using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae.Speleomantes;

/// <summary>
/// Abstract class for Speleomantes (genus).
/// NCBI TaxId: 486473
/// </summary>
public abstract class Speleomantes : Plethodontidae, ISpeleomantes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Speleomantes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 486473;

    /// <inheritdoc />
    public virtual string GenusName => "Speleomantes";

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
