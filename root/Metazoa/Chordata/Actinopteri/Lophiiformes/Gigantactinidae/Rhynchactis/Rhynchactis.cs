using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Gigantactinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Gigantactinidae.Rhynchactis;

/// <summary>
/// Abstract class for Rhynchactis (genus).
/// NCBI TaxId: 412648
/// </summary>
public abstract class Rhynchactis : Gigantactinidae, IRhynchactis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhynchactis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 412648;

    /// <inheritdoc />
    public virtual string GenusName => "Rhynchactis";

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
