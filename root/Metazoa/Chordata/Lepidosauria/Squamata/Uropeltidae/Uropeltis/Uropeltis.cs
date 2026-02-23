using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Uropeltidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Uropeltidae.Uropeltis;

/// <summary>
/// Abstract class for Uropeltis (genus).
/// NCBI TaxId: 186614
/// </summary>
public abstract class Uropeltis : Uropeltidae, IUropeltis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Uropeltis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 186614;

    /// <inheritdoc />
    public virtual string GenusName => "Uropeltis";

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
