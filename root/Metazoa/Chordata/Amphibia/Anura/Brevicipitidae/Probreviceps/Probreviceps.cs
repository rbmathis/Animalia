using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Brevicipitidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Brevicipitidae.Probreviceps;

/// <summary>
/// Abstract class for Probreviceps (genus).
/// NCBI TaxId: 68435
/// </summary>
public abstract class Probreviceps : Brevicipitidae, IProbreviceps
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Probreviceps";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 68435;

    /// <inheritdoc />
    public virtual string GenusName => "Probreviceps";

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
