using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Iguanidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Iguanidae.Enyalioides;

/// <summary>
/// Abstract class for Enyalioides (genus).
/// NCBI TaxId: 51205
/// </summary>
public abstract class Enyalioides : Iguanidae, IEnyalioides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Enyalioides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 51205;

    /// <inheritdoc />
    public virtual string GenusName => "Enyalioides";

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
