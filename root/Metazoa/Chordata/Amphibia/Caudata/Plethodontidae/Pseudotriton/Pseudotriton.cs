using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae.Pseudotriton;

/// <summary>
/// Abstract class for Pseudotriton (genus).
/// NCBI TaxId: 134761
/// </summary>
public abstract class Pseudotriton : Plethodontidae, IPseudotriton
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudotriton";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 134761;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudotriton";

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
