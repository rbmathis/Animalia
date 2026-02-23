using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Zosteropidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Zosteropidae.Megazosterops;

/// <summary>
/// Abstract class for Megazosterops (genus).
/// NCBI TaxId: 2771524
/// </summary>
public abstract class Megazosterops : Zosteropidae, IMegazosterops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Megazosterops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2771524;

    /// <inheritdoc />
    public virtual string GenusName => "Megazosterops";

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
