using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Agasthyagama;

/// <summary>
/// Abstract class for Agasthyagama (genus).
/// NCBI TaxId: 2874784
/// </summary>
public abstract class Agasthyagama : Agamidae, IAgasthyagama
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Agasthyagama";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2874784;

    /// <inheritdoc />
    public virtual string GenusName => "Agasthyagama";

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
