using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae.Philochortus;

/// <summary>
/// Abstract class for Philochortus (genus).
/// NCBI TaxId: 450827
/// </summary>
public abstract class Philochortus : Lacertidae, IPhilochortus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Philochortus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 450827;

    /// <inheritdoc />
    public virtual string GenusName => "Philochortus";

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
