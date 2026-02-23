using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Brevicipitidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Brevicipitidae.Balebreviceps;

/// <summary>
/// Abstract class for Balebreviceps (genus).
/// NCBI TaxId: 756415
/// </summary>
public abstract class Balebreviceps : Brevicipitidae, IBalebreviceps
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Balebreviceps";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 756415;

    /// <inheritdoc />
    public virtual string GenusName => "Balebreviceps";

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
