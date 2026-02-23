using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hemiphractidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hemiphractidae.Flectonotus;

/// <summary>
/// Abstract class for Flectonotus (genus).
/// NCBI TaxId: 317317
/// </summary>
public abstract class Flectonotus : Hemiphractidae, IFlectonotus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Flectonotus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 317317;

    /// <inheritdoc />
    public virtual string GenusName => "Flectonotus";

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
