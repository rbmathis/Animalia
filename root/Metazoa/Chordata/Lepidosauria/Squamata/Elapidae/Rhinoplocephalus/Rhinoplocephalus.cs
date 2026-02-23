using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Rhinoplocephalus;

/// <summary>
/// Abstract class for Rhinoplocephalus (genus).
/// NCBI TaxId: 292441
/// </summary>
public abstract class Rhinoplocephalus : Elapidae, IRhinoplocephalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhinoplocephalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 292441;

    /// <inheritdoc />
    public virtual string GenusName => "Rhinoplocephalus";

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
