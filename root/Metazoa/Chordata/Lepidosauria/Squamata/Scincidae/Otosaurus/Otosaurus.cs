using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Otosaurus;

/// <summary>
/// Abstract class for Otosaurus (genus).
/// NCBI TaxId: 1353232
/// </summary>
public abstract class Otosaurus : Scincidae, IOtosaurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Otosaurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1353232;

    /// <inheritdoc />
    public virtual string GenusName => "Otosaurus";

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
