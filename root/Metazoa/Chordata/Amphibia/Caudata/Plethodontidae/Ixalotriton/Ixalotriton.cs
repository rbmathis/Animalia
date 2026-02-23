using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae.Ixalotriton;

/// <summary>
/// Abstract class for Ixalotriton (genus).
/// NCBI TaxId: 187951
/// </summary>
public abstract class Ixalotriton : Plethodontidae, IIxalotriton
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ixalotriton";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 187951;

    /// <inheritdoc />
    public virtual string GenusName => "Ixalotriton";

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
