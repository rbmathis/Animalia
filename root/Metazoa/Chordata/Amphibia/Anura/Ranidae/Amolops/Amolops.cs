using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Amolops;

/// <summary>
/// Abstract class for Amolops (genus).
/// NCBI TaxId: 109940
/// </summary>
public abstract class Amolops : Ranidae, IAmolops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Amolops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 109940;

    /// <inheritdoc />
    public virtual string GenusName => "Amolops";

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
