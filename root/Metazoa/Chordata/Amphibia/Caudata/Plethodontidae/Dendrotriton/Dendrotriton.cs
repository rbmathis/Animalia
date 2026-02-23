using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae.Dendrotriton;

/// <summary>
/// Abstract class for Dendrotriton (genus).
/// NCBI TaxId: 107965
/// </summary>
public abstract class Dendrotriton : Plethodontidae, IDendrotriton
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dendrotriton";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 107965;

    /// <inheritdoc />
    public virtual string GenusName => "Dendrotriton";

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
