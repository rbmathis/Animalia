using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Canidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Canidae.Cuon;

/// <summary>
/// Abstract class for Cuon (genus).
/// NCBI TaxId: 68729
/// </summary>
public abstract class Cuon : Canidae, ICuon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cuon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 68729;

    /// <inheritdoc />
    public virtual string GenusName => "Cuon";

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
