using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Ceratophora;

/// <summary>
/// Abstract class for Ceratophora (genus).
/// NCBI TaxId: 118084
/// </summary>
public abstract class Ceratophora : Agamidae, ICeratophora
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ceratophora";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 118084;

    /// <inheritdoc />
    public virtual string GenusName => "Ceratophora";

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
