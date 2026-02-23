using AnimalKingdom.root.Metazoa.Chordata.Testudines.Trionychidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Trionychidae.Pelodiscus;

/// <summary>
/// Abstract class for Pelodiscus (genus).
/// NCBI TaxId: 204969
/// </summary>
public abstract class Pelodiscus : Trionychidae, IPelodiscus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pelodiscus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 204969;

    /// <inheritdoc />
    public virtual string GenusName => "Pelodiscus";

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
