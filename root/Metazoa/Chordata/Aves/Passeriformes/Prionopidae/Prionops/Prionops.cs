using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Prionopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Prionopidae.Prionops;

/// <summary>
/// Abstract class for Prionops (genus).
/// NCBI TaxId: 254644
/// </summary>
public abstract class Prionops : Prionopidae, IPrionops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Prionops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 254644;

    /// <inheritdoc />
    public virtual string GenusName => "Prionops";

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
