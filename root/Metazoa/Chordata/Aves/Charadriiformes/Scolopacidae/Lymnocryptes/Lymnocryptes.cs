using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Scolopacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Scolopacidae.Lymnocryptes;

/// <summary>
/// Abstract class for Lymnocryptes (genus).
/// NCBI TaxId: 107378
/// </summary>
public abstract class Lymnocryptes : Scolopacidae, ILymnocryptes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lymnocryptes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 107378;

    /// <inheritdoc />
    public virtual string GenusName => "Lymnocryptes";

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
