using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Scolopacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Scolopacidae.Tringa;

/// <summary>
/// Abstract class for Tringa (genus).
/// NCBI TaxId: 161681
/// </summary>
public abstract class Tringa : Scolopacidae, ITringa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tringa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 161681;

    /// <inheritdoc />
    public virtual string GenusName => "Tringa";

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
