using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dicroglossidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dicroglossidae.Euphlyctis;

/// <summary>
/// Abstract class for Euphlyctis (genus).
/// NCBI TaxId: 58518
/// </summary>
public abstract class Euphlyctis : Dicroglossidae, IEuphlyctis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Euphlyctis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 58518;

    /// <inheritdoc />
    public virtual string GenusName => "Euphlyctis";

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
