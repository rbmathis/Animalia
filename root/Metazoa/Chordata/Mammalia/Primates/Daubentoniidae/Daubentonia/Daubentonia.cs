using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Daubentoniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Daubentoniidae.Daubentonia;

/// <summary>
/// Abstract class for Daubentonia (genus).
/// NCBI TaxId: 13038
/// </summary>
public abstract class Daubentonia : Daubentoniidae, IDaubentonia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Daubentonia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 13038;

    /// <inheritdoc />
    public virtual string GenusName => "Daubentonia";

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
