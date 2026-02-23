using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Brevicipitidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Brevicipitidae.Breviceps;

/// <summary>
/// Abstract class for Breviceps (genus).
/// NCBI TaxId: 143558
/// </summary>
public abstract class Breviceps : Brevicipitidae, IBreviceps
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Breviceps";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 143558;

    /// <inheritdoc />
    public virtual string GenusName => "Breviceps";

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
