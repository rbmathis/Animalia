using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae.Pseudoeurycea;

/// <summary>
/// Abstract class for Pseudoeurycea (genus).
/// NCBI TaxId: 164021
/// </summary>
public abstract class Pseudoeurycea : Plethodontidae, IPseudoeurycea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudoeurycea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 164021;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudoeurycea";

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
