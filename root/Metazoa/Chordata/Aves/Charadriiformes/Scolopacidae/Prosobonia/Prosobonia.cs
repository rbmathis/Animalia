using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Scolopacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Scolopacidae.Prosobonia;

/// <summary>
/// Abstract class for Prosobonia (genus).
/// NCBI TaxId: 1233976
/// </summary>
public abstract class Prosobonia : Scolopacidae, IProsobonia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Prosobonia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1233976;

    /// <inheritdoc />
    public virtual string GenusName => "Prosobonia";

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
