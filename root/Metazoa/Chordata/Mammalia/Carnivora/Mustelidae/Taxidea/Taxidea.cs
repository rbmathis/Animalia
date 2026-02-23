using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae.Taxidea;

/// <summary>
/// Abstract class for Taxidea (genus).
/// NCBI TaxId: 30553
/// </summary>
public abstract class Taxidea : Mustelidae, ITaxidea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Taxidea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 30553;

    /// <inheritdoc />
    public virtual string GenusName => "Taxidea";

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
