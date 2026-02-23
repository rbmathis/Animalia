using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Anguidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Anguidae.Gerrhonotus;

/// <summary>
/// Abstract class for Gerrhonotus (genus).
/// NCBI TaxId: 76653
/// </summary>
public abstract class Gerrhonotus : Anguidae, IGerrhonotus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gerrhonotus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 76653;

    /// <inheritdoc />
    public virtual string GenusName => "Gerrhonotus";

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
