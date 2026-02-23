using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Paroplocephalus;

/// <summary>
/// Abstract class for Paroplocephalus (genus).
/// NCBI TaxId: 1353234
/// </summary>
public abstract class Paroplocephalus : Elapidae, IParoplocephalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paroplocephalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1353234;

    /// <inheritdoc />
    public virtual string GenusName => "Paroplocephalus";

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
