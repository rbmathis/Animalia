using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Glossophaga;

/// <summary>
/// Abstract class for Glossophaga (genus).
/// NCBI TaxId: 27637
/// </summary>
public abstract class Glossophaga : Phyllostomidae, IGlossophaga
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Glossophaga";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 27637;

    /// <inheritdoc />
    public virtual string GenusName => "Glossophaga";

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
