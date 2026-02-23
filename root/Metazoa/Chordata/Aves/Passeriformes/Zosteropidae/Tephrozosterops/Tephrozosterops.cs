using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Zosteropidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Zosteropidae.Tephrozosterops;

/// <summary>
/// Abstract class for Tephrozosterops (genus).
/// NCBI TaxId: 2485356
/// </summary>
public abstract class Tephrozosterops : Zosteropidae, ITephrozosterops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tephrozosterops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2485356;

    /// <inheritdoc />
    public virtual string GenusName => "Tephrozosterops";

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
