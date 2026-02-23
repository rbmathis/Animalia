using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Typhlopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Typhlopidae.Anilios;

/// <summary>
/// Abstract class for Anilios (genus).
/// NCBI TaxId: 1539840
/// </summary>
public abstract class Anilios : Typhlopidae, IAnilios
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anilios";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1539840;

    /// <inheritdoc />
    public virtual string GenusName => "Anilios";

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
