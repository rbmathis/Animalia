using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Terapontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Terapontidae.Rhynchopelates;

/// <summary>
/// Abstract class for Rhynchopelates (genus).
/// NCBI TaxId: 270584
/// </summary>
public abstract class Rhynchopelates : Terapontidae, IRhynchopelates
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhynchopelates";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 270584;

    /// <inheritdoc />
    public virtual string GenusName => "Rhynchopelates";

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
