using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Alytidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Alytidae.Latonia;

/// <summary>
/// Abstract class for Latonia (genus).
/// NCBI TaxId: 1431193
/// </summary>
public abstract class Latonia : Alytidae, ILatonia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Latonia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1431193;

    /// <inheritdoc />
    public virtual string GenusName => "Latonia";

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
