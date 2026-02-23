using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Homalopsidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Homalopsidae.Sumatranus;

/// <summary>
/// Abstract class for Sumatranus (genus).
/// NCBI TaxId: 2911144
/// </summary>
public abstract class Sumatranus : Homalopsidae, ISumatranus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sumatranus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2911144;

    /// <inheritdoc />
    public virtual string GenusName => "Sumatranus";

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
