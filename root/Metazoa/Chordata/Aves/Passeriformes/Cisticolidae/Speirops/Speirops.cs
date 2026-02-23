using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cisticolidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cisticolidae.Speirops;

/// <summary>
/// Abstract class for Speirops (genus).
/// NCBI TaxId: 364609
/// </summary>
public abstract class Speirops : Cisticolidae, ISpeirops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Speirops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 364609;

    /// <inheritdoc />
    public virtual string GenusName => "Speirops";

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
