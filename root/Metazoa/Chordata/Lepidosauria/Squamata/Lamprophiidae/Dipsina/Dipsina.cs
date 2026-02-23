using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Dipsina;

/// <summary>
/// Abstract class for Dipsina (genus).
/// NCBI TaxId: 382765
/// </summary>
public abstract class Dipsina : Lamprophiidae, IDipsina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dipsina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 382765;

    /// <inheritdoc />
    public virtual string GenusName => "Dipsina";

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
