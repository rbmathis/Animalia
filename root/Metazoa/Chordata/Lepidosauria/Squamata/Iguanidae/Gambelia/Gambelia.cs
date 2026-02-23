using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Iguanidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Iguanidae.Gambelia;

/// <summary>
/// Abstract class for Gambelia (genus).
/// NCBI TaxId: 43592
/// </summary>
public abstract class Gambelia : Iguanidae, IGambelia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gambelia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 43592;

    /// <inheritdoc />
    public virtual string GenusName => "Gambelia";

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
