using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Contopus;

/// <summary>
/// Abstract class for Contopus (genus).
/// NCBI TaxId: 183520
/// </summary>
public abstract class Contopus : Tyrannidae, IContopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Contopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 183520;

    /// <inheritdoc />
    public virtual string GenusName => "Contopus";

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
