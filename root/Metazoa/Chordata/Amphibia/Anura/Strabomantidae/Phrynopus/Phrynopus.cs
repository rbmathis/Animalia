using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Strabomantidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Strabomantidae.Phrynopus;

/// <summary>
/// Abstract class for Phrynopus (genus).
/// NCBI TaxId: 248866
/// </summary>
public abstract class Phrynopus : Strabomantidae, IPhrynopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phrynopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 248866;

    /// <inheritdoc />
    public virtual string GenusName => "Phrynopus";

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
