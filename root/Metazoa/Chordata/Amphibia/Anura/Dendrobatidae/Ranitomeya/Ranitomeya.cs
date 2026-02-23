using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dendrobatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dendrobatidae.Ranitomeya;

/// <summary>
/// Abstract class for Ranitomeya (genus).
/// NCBI TaxId: 1004436
/// </summary>
public abstract class Ranitomeya : Dendrobatidae, IRanitomeya
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ranitomeya";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1004436;

    /// <inheritdoc />
    public virtual string GenusName => "Ranitomeya";

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
