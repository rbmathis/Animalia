using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Scolopacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Scolopacidae.Phalaropus;

/// <summary>
/// Abstract class for Phalaropus (genus).
/// NCBI TaxId: 227174
/// </summary>
public abstract class Phalaropus : Scolopacidae, IPhalaropus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phalaropus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 227174;

    /// <inheritdoc />
    public virtual string GenusName => "Phalaropus";

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
