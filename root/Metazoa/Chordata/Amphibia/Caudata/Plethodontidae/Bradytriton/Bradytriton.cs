using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae.Bradytriton;

/// <summary>
/// Abstract class for Bradytriton (genus).
/// NCBI TaxId: 269189
/// </summary>
public abstract class Bradytriton : Plethodontidae, IBradytriton
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bradytriton";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 269189;

    /// <inheritdoc />
    public virtual string GenusName => "Bradytriton";

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
