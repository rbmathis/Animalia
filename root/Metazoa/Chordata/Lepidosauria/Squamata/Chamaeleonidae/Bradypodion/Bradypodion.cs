using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Chamaeleonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Chamaeleonidae.Bradypodion;

/// <summary>
/// Abstract class for Bradypodion (genus).
/// NCBI TaxId: 103708
/// </summary>
public abstract class Bradypodion : Chamaeleonidae, IBradypodion
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bradypodion";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 103708;

    /// <inheritdoc />
    public virtual string GenusName => "Bradypodion";

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
