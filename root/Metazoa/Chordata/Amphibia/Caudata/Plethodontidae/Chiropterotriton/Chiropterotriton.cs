using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae.Chiropterotriton;

/// <summary>
/// Abstract class for Chiropterotriton (genus).
/// NCBI TaxId: 269191
/// </summary>
public abstract class Chiropterotriton : Plethodontidae, IChiropterotriton
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chiropterotriton";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 269191;

    /// <inheritdoc />
    public virtual string GenusName => "Chiropterotriton";

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
