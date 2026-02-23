using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Colobosaura;

/// <summary>
/// Abstract class for Colobosaura (genus).
/// NCBI TaxId: 174744
/// </summary>
public abstract class Colobosaura : Gymnophthalmidae, IColobosaura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Colobosaura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 174744;

    /// <inheritdoc />
    public virtual string GenusName => "Colobosaura";

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
