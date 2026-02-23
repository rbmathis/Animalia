using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Rhachidelus;

/// <summary>
/// Abstract class for Rhachidelus (genus).
/// NCBI TaxId: 1260353
/// </summary>
public abstract class Rhachidelus : Dipsadidae, IRhachidelus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhachidelus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1260353;

    /// <inheritdoc />
    public virtual string GenusName => "Rhachidelus";

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
