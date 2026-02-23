using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Scolopacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Scolopacidae.Gallinago;

/// <summary>
/// Abstract class for Gallinago (genus).
/// NCBI TaxId: 107376
/// </summary>
public abstract class Gallinago : Scolopacidae, IGallinago
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gallinago";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 107376;

    /// <inheritdoc />
    public virtual string GenusName => "Gallinago";

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
