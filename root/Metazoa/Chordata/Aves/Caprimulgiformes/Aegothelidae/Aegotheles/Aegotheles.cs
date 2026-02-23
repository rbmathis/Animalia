using AnimalKingdom.root.Metazoa.Chordata.Aves.Caprimulgiformes.Aegothelidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Caprimulgiformes.Aegothelidae.Aegotheles;

/// <summary>
/// Abstract class for Aegotheles (genus).
/// NCBI TaxId: 48276
/// </summary>
public abstract class Aegotheles : Aegothelidae, IAegotheles
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aegotheles";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 48276;

    /// <inheritdoc />
    public virtual string GenusName => "Aegotheles";

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
