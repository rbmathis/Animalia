using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Scolopacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Scolopacidae.Bartramia;

/// <summary>
/// Abstract class for Bartramia (genus).
/// NCBI TaxId: 279932
/// </summary>
public abstract class Bartramia : Scolopacidae, IBartramia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bartramia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 279932;

    /// <inheritdoc />
    public virtual string GenusName => "Bartramia";

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
