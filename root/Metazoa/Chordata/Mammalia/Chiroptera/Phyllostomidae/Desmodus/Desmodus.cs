using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Desmodus;

/// <summary>
/// Abstract class for Desmodus (genus).
/// NCBI TaxId: 9429
/// </summary>
public abstract class Desmodus : Phyllostomidae, IDesmodus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Desmodus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9429;

    /// <inheritdoc />
    public virtual string GenusName => "Desmodus";

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
