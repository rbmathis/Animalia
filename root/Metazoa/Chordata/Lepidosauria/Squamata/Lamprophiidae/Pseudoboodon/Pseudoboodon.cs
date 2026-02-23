using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Pseudoboodon;

/// <summary>
/// Abstract class for Pseudoboodon (genus).
/// NCBI TaxId: 382771
/// </summary>
public abstract class Pseudoboodon : Lamprophiidae, IPseudoboodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudoboodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 382771;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudoboodon";

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
