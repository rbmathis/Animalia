using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Arthroleptidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Arthroleptidae.Scotobleps;

/// <summary>
/// Abstract class for Scotobleps (genus).
/// NCBI TaxId: 143463
/// </summary>
public abstract class Scotobleps : Arthroleptidae, IScotobleps
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scotobleps";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 143463;

    /// <inheritdoc />
    public virtual string GenusName => "Scotobleps";

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
