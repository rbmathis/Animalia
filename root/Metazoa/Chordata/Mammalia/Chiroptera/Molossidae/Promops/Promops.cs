using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Molossidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Molossidae.Promops;

/// <summary>
/// Abstract class for Promops (genus).
/// NCBI TaxId: 27628
/// </summary>
public abstract class Promops : Molossidae, IPromops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Promops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 27628;

    /// <inheritdoc />
    public virtual string GenusName => "Promops";

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
