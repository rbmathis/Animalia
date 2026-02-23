using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Scolopacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Scolopacidae.Numenius;

/// <summary>
/// Abstract class for Numenius (genus).
/// NCBI TaxId: 32638
/// </summary>
public abstract class Numenius : Scolopacidae, INumenius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Numenius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 32638;

    /// <inheritdoc />
    public virtual string GenusName => "Numenius";

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
