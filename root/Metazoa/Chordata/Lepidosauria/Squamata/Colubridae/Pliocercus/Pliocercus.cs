using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Pliocercus;

/// <summary>
/// Abstract class for Pliocercus (genus).
/// NCBI TaxId: 699590
/// </summary>
public abstract class Pliocercus : Colubridae, IPliocercus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pliocercus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 699590;

    /// <inheritdoc />
    public virtual string GenusName => "Pliocercus";

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
