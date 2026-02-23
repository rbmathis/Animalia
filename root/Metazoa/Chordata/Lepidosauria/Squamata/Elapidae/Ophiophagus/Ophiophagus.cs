using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Ophiophagus;

/// <summary>
/// Abstract class for Ophiophagus (genus).
/// NCBI TaxId: 8664
/// </summary>
public abstract class Ophiophagus : Elapidae, IOphiophagus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ophiophagus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8664;

    /// <inheritdoc />
    public virtual string GenusName => "Ophiophagus";

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
